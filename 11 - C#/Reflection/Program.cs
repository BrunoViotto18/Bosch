using System.Reflection;
using static System.Console;
using System.Data.SqlClient;
using System.Data;


// Cria uma conexão com o banco
using SqlConnection conn = new SqlConnection("Data Source=JVLPC0524;Initial Catalog=Reflection;Integrated Security=True");

// Abre a conexão com o banco
conn.Open();

// Retorna o Assembly atual
var assembly = Assembly.GetExecutingAssembly();

// Cria tabelas com as classes do assembly atual
// Que tenham o atributo Table ou TableAttribute
CreateDatatablesFromAssemblyClasses(assembly, conn);



Access<Cliente> acesso = new Access<Cliente>();

foreach (Cliente obj in acesso.All(conn))
{
    WriteLine($"{obj.cliente_id}");
    WriteLine($"{obj.name}");
}


// Cria tabelas no banco de dados
// Das classes do assembly atual
// Que tenham o atributo Table ou TableAttribute
static void CreateDatatablesFromAssemblyClasses(Assembly assembly, SqlConnection conn)
{
    // Itera sobre todas as classes do assembly atual
    foreach (var type in assembly.GetTypes())
    {
        // Se classe nao for uma tabela SQL:
        // Verificar próxima classe do programa
        if (type.GetCustomAttribute<TableAttribute>() == null)
        {
            continue;
        }

        // Seleciona todas as tabelas do servidor e insere em dt
        DataTable dt = new DataTable();
        SqlDataAdapter sys = new SqlDataAdapter($"SELECT * FROM sys.tables WHERE name = '{type.Name}'", conn);
        sys.Fill(dt);

        // Se tabela já existe:
        // Continuar para próxima classe
        if (dt.Rows.Count != 0)
            continue;

        // Cria a query de criar uma tabela
        string CreateTable = $"CREATE TABLE {type.Name}(\n\t";

        // Cria os campos da tabela (1 campo por iteração)
        foreach (PropertyInfo propriedade in type.GetProperties())
        {
            CreateTable += $"{CreateField(propriedade)}";
        }

        // Remove caracteres extras da string
        CreateTable = CreateTable.Remove(CreateTable.Length - 3, 3);

        // Adiciona o final da query de criação de tabela
        CreateTable += "\n);";

        // Cria a tabela no banco de dados
        SqlCommand cmd = new SqlCommand(CreateTable, conn);
        cmd.ExecuteNonQuery();
    }
}


// Cria o campo a ser inserido em uma query de criação de tabela
static string CreateField(PropertyInfo property)
{
    string campo = "";

    // Adiciona o nome do campo
    campo += property.Name;

    // Adiciona o tipo do campo
    campo += AttachFieldType(property);

    // Adiciona os constraints do campo
    campo += AttachFieldConstraints(property);

    // Retorna
    return campo;
}


// Retorna o tipo do atributo infromado
static string AttachFieldType(PropertyInfo property)
{
    // Retorna um atributo que herde da classe 'TypeAttribute'
    TypeAttribute? atributo = property.GetCustomAttribute<TypeAttribute>();

    // Se o atributo não existir:
    // Levantar Exceção
    if (atributo == null)
        throw new Exception();

    // Retornar atributo
    return $" {atributo.Type}";
}


// Retorna os constraints do atributo informado
static string AttachFieldConstraints(PropertyInfo property)
{
    string attributeConstraints = "";

    // retorna uma lista de Constraints da propriedade
    IEnumerable<ConstraintAttribute> constraints = property.GetCustomAttributes<ConstraintAttribute>();

    // Para cada constraint, adicioná-lo a string de constraints
    foreach(ConstraintAttribute constraint in constraints)
    {
        attributeConstraints += $" {constraint.Constraint}";
    }

    // Retorna a string de constraints
    return $"{attributeConstraints},\n\t";
}



// Table

// Define se uma classe é uma tabela do SQL
public class TableAttribute : Attribute
{

}



// Atribute Constraints

// Classe abstrata para definir constraints
public abstract class ConstraintAttribute : Attribute
{
    public abstract string Constraint { get; set; }
}

// Primary Key
public class PrimaryKeyAttribute : ConstraintAttribute
{
    public override string Constraint { get; set; } = "PRIMARY KEY";
}

// Not Null
public class NotNullAttribute : ConstraintAttribute
{
    public override string Constraint { get; set; } = "NOT NULL";
}

// Identity()
public class IdentityAttribute : ConstraintAttribute
{
    public int Init { get; set; }
    public int Step { get; set; }
    public override string Constraint { get; set; } = "IDENTITY";

    public IdentityAttribute(int init = 1, int step = 1)
    {
        this.Init = init;
        this.Step = step;
        if (this.Init != 1 || this.Step != 1)
        {
            this.Constraint += $"({this.Init},{this.Step})";
        }
    }
}



// Tipos

// Classe abstrata para definir tipos
public abstract class TypeAttribute : Attribute
{
    public abstract string Type { get; set; }
}

// INT
public class IntAttribute : TypeAttribute
{
    public override string Type { get; set; } = "INT";
}

// CHAR
public class CharAttribute : TypeAttribute
{
    public override string Type { get; set; } = "CHAR";
}

// VARCHAR()
public class VarcharAttribute : TypeAttribute
{
    public int Size { get; set; }
    public override string Type { get; set; }

    public VarcharAttribute(int size)
    {
        this.Size = size;
        this.Type = $"VARCHAR({size})";
    }
}

// DATE
public class DateAttribute : TypeAttribute
{
    public override string Type { get; set; } = "DATE";
}

// BOOL
public class BoolAttribute : TypeAttribute
{
    public override string Type { get; set; } = "BOOL";
}



// Tabelas
[Table]
public class Cliente
{
    [PrimaryKey]
    [Identity]
    [NotNull]
    [Int]
    public int cliente_id { get; set; }
    [NotNull]
    [Varchar(100)]
    public string name { get; set; }
}

public class Access<T>
    where T : new()
{
    public List<T> All(SqlConnection conn)
    {
        // Puxa todos os dados de uma tabela
        DataTable dt = new DataTable();
        SqlDataAdapter select = new SqlDataAdapter($"SELECT * FROM {typeof(T).Name}", conn);
        select.Fill(dt);

        // Cria uma lista de T's
        List<T> all = new List<T>();

        // Itera todas as linhas da tabela
        foreach (DataRow row in dt.Rows)
        {
            // Cria um novo objeto T
            T t = new T();

            // Obtém um array das propriedades de T
            PropertyInfo[] props = typeof(T).GetProperties();

            // Itera pelas colunas da linha atual
            // E atribui os valores para o objeto 't'
            for(int item = 0; item < row.ItemArray.Length; item++)
            {
                props[item].SetValue(t, row.ItemArray[item]);
            }

            // Adiciona o objeto para a lista
            all.Add(t);
        }
        // Retorna a lista
        return all;
    }
}

