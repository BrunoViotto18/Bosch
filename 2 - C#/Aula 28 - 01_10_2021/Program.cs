using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Aluno
    {
        string Nome = "";
        int Matricula = -1;
        string Curso = "";
        int Periodo = -1;
        Discipline Disciplinas;
        int Idade = -1;
        Address Endereço;

        public Aluno(string Nome, int Matricula, string Curso, int Periodo, int Idade, Discipline Disciplinas, Address Endereço)
        {
            if (Nome.Length >= 3)
            {
                this.Nome = Nome;
            }
            this.Matricula = Matricula;
            this.Curso = Curso;
            if (Periodo >= 1 && Periodo <= 3)
            {
                this.Periodo = Periodo;
            }
            if (Idade >= 18 && Idade <= 135)
            {
                this.Idade = Idade;
            }
            this.Disciplinas = Disciplinas;
            this.Endereço = Endereço;
        }

        public void SetNome(string Nome)
        {
            if (Nome.Length >= 3)
            {
                this.Nome = Nome;
            }
        }

        public void SetMatricula(int Matricula)
        {
            this.Matricula = Matricula;
        }

        public void SetCurso(string Curso)
        {
            this.Curso = Curso;
        }

        public void SetPeriodo(int Periodo)
        {
            if (Periodo >= 1 && Periodo <= 3)
            {
                this.Periodo = Periodo;
            }
        }

        public void SetIdade(int Idade)
        {
            if (Idade >= 18 && Idade <= 135)
            {
                this.Idade = Idade;
            }
        }

        public string GetNome()
        {
            return Nome;
        }

        public int GetMatricula()
        {
            return Matricula;
        }

        public string GetCurso()
        {
            return Curso;
        }

        public int GetPeriodo()
        {
            return Periodo;
        }

        public Discipline GetDisciplinas()
        {
            return Disciplinas;
        }

        public int GetIdade()
        {
            return Idade;
        }

        public Address GetEndereço()
        {
            return Endereço;
        }
    }

    class Discipline
    {
        string Disciplina = "";
        string Horario = "";
        int Creditos = 0;

        public Discipline(string Disciplina, string Horario)
        {
            this.Disciplina = Disciplina;
            this.Horario = Horario;
        }

        public void SetDisciplina(string Disciplina)
        {
            this.Disciplina = Disciplina;
        }

        public void SetHorario(string Horario)
        {
            this.Horario = Horario;
        }

        public void SetCreditos(int Creditos)
        {
            if (Creditos >= 0)
            {
                this.Creditos = Creditos;
            }
        }

        public string GetDisciplina()
        {
            return Disciplina;
        }

        public string GetHorario()
        {
            return Horario;
        }

        public int GetCreditos()
        {
            return Creditos;
        }
    }

    class Address
    {
        string Pais = "";
        string Estado = "";
        string Cidade = "";
        string Bairro = "";
        string Rua = "";
        int Numero = -1;
        string Complemento = "";
        int CEP = -1;

        public Address(string Pais, string Estado, string Cidade, string Bairro, string Rua, int Numero, string Complemento, int CEP)
        {
            this.Pais = Pais;
            this.Estado = Estado;
            this.Cidade = Cidade;
            this.Bairro = Bairro;
            this.Rua = Rua;
            if (Numero >= 0)
            {
                this.Numero = Numero;
            }
            this.Complemento = Complemento;
            if (CEP >= 0 && CEP <= 99999999)
            {
                this.CEP = CEP;
            }
        }

        public void SetPais(string Pais)
        {
            this.Pais = Pais;
        }

        public void SetEstado(string Estado)
        {
            this.Estado = Estado;
        }

        public void SetCidade(string Cidade)
        {
            this.Cidade = Cidade;
        }

        public void SetBairro(string Bairro)
        {
            this.Bairro = Bairro;
        }

        public void SetRua(string Rua)
        {
            this.Rua = Rua;
        }

        public void SetNumero(int Numero)
        {
            if (Numero >= 0)
            {
                this.Numero = Numero;
            }
        }

        public void SetComplemento(string Complemento)
        {
            this.Complemento = Complemento;
        }

        public void SetCEP(int CEP)
        {
            if (CEP >= 0 && CEP <= 99999999)
            {
                this.CEP = CEP;
            }
        }

        public string GetPais()
        {
            return Pais;
        }

        public string GetEstado()
        {
            return Estado;
        }

        public string GetCidade()
        {
            return Cidade;
        }

        public string GetBairro()
        {
            return Bairro;
        }

        public string GetRua()
        {
            return Rua;
        }

        public int GetNumero()
        {
            return Numero;
        }

        public string GetComplemento()
        {
            return Complemento;
        }

        public int GetCEP()
        {
            return CEP;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // EX001 - Cadastrar Alunos (650 Linhas)
            {
                /*Console.WriteLine("PROGRAMA ALUNOS");

                List<Aluno> Alunos = new List<Aluno> { };
                bool con = true;
                while (con)
                {
                    Console.Write(
                        $"\n[ 1 ] Cadastrar Aluno" +
                        $"\n[ 2 ] Listar Aluno" +
                        $"\n[ 3 ] Listar Alunos" +
                        $"\n[ 4 ] Atualizar Dados" +
                        $"\n[ 5 ] Excluir Aluno" +
                        $"\n[ 6 ] Sair" +
                        $"\nSua Escolha: ");
                    int op = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (op)
                    {
                        case 1:
                            Alunos = CadastrarAluno(Alunos);
                            break;

                        case 2:
                            ListarAluno(Alunos);
                            break;

                        case 3:
                            ListarAlunos(Alunos);
                            break;

                        case 4:
                            Alunos = AtualizarDados(Alunos);
                            break;

                        case 5:
                            Alunos = ExcluirAluno(Alunos);
                            break;

                        case 6:
                            con = false;
                            break;

                        default:
                            Console.WriteLine("Valor Inválido! Tente novamente.");
                            break;
                    }
                }*/
            }
            // Fim;
        }
        static List<Aluno> CadastrarAluno(List<Aluno> Lista)
        {
            Console.WriteLine("Cadastrar Aluno\n");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Matricula: ");
            int Matricula = int.Parse(Console.ReadLine());
            Console.Write("Curso: ");
            string Curso = Console.ReadLine();
            Console.Write("Periodo: ");
            int Periodo = int.Parse(Console.ReadLine());
            Console.Write("Idade: ");
            int Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDisciplinas\n");
            Console.Write("Disciplina: ");
            string Disciplina = Console.ReadLine();
            Console.Write("Horário: ");
            string Horario = Console.ReadLine();

            Console.WriteLine("\nEndereço\n");
            Console.Write("País: ");
            string Pais = Console.ReadLine();
            Console.Write("Estado: ");
            string Estado = Console.ReadLine();
            Console.Write("Cidade: ");
            string Cidade = Console.ReadLine();
            Console.Write("Bairro: ");
            string Bairro = Console.ReadLine();
            Console.Write("Rua: ");
            string Rua = Console.ReadLine();
            Console.Write("Número: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.Write("Complemento: ");
            string Complemento = Console.ReadLine();
            Console.Write("CEP: ");
            int CEP = int.Parse(Console.ReadLine());

            Discipline Disciplinas = new Discipline(Disciplina, Horario);
            Address Endereço = new Address(Pais, Estado, Cidade, Bairro, Rua, Numero, Complemento, CEP);
            Aluno Aluno = new Aluno(Nome, Matricula, Curso, Periodo, Idade, Disciplinas, Endereço);

            Lista.Add(Aluno);
            Console.WriteLine("Aluno Cadastrado Com Sucesso!");

            return Lista;
        }

        static void ListarAluno(List<Aluno> Lista)
        {
            Console.Write("Digite o Número de Matrícula do Aluno: ");
            int matricula = int.Parse(Console.ReadLine());

            int i = -1;
            foreach(Aluno Aluno in Lista)
            {
                if (matricula == Aluno.GetMatricula())
                {
                    i = Lista.IndexOf(Aluno);
                    break;
                }
            }

            Aluno aluno = Lista[i];
            Console.WriteLine(
                $"\nAluno {aluno.GetNome()}" +
                $"\nMatricula: {aluno.GetMatricula()}" +
                $"\nIdade: {aluno.GetIdade()} anos" +
                $"\nCurso: {aluno.GetCurso()}" +
                $"\nPeríodo: {aluno.GetPeriodo()}º período" +
                $"\n" +
                $"\nDisciplina: {aluno.GetDisciplinas().GetDisciplina()}" +
                $"\nHorario: {aluno.GetDisciplinas().GetHorario()} horas" +
                $"\nCreditos: {aluno.GetDisciplinas().GetCreditos()} créditos" +
                $"\n" +
                $"\nPaís: {aluno.GetEndereço().GetPais()}" +
                $"\nEstado: {aluno.GetEndereço().GetEstado()}" +
                $"\nCidade: {aluno.GetEndereço().GetCidade()}" +
                $"\nBairro: {aluno.GetEndereço().GetBairro()}" +
                $"\nRua: {aluno.GetEndereço().GetRua()}, {aluno.GetEndereço().GetNumero()}" +
                $"\nComplemento: {aluno.GetEndereço().GetComplemento()}" +
                $"\nCEP: {aluno.GetEndereço().GetCEP()}");
        }

        static void ListarAlunos(List<Aluno> Lista)
        {
            Console.WriteLine("Lista de Alunos");
            int i = 1;
            foreach (Aluno aluno in Lista)
            {
                Console.WriteLine(
                    $"\n{i}º Aluno {aluno.GetNome()}" +
                    $"\nMatricula: {aluno.GetMatricula()}" +
                    $"\nIdade: {aluno.GetIdade()} anos" +
                    $"\nCurso: {aluno.GetCurso()}" +
                    $"\nPeríodo: {aluno.GetPeriodo()}º período" +
                    $"\n" +
                    $"\nDisciplina: {aluno.GetDisciplinas().GetDisciplina()}" +
                    $"\nHorario: {aluno.GetDisciplinas().GetHorario()} horas" +
                    $"\nCreditos: {aluno.GetDisciplinas().GetCreditos()} créditos" +
                    $"\n" +
                    $"\nPaís: {aluno.GetEndereço().GetPais()}" +
                    $"\nEstado: {aluno.GetEndereço().GetEstado()}" +
                    $"\nCidade: {aluno.GetEndereço().GetCidade()}" +
                    $"\nBairro: {aluno.GetEndereço().GetBairro()}" +
                    $"\nRua: {aluno.GetEndereço().GetRua()}, {aluno.GetEndereço().GetNumero()}" +
                    $"\nComplemento: {aluno.GetEndereço().GetComplemento()}" +
                    $"\nCEP: {aluno.GetEndereço().GetCEP()}");
                i++;
            }
        }

        static List<Aluno> AtualizarDados(List<Aluno> Lista)
        {
            int i = -1;

            {
                Console.Write("Digite o Número de Matrícula do Aluno: ");
                int matricula = int.Parse(Console.ReadLine());

                foreach (Aluno aluno in Lista)
                {
                    if (matricula == aluno.GetMatricula())
                    {
                        i = Lista.IndexOf(aluno);
                        break;
                    }
                }
            }

            if (i == -1)
            {
                Console.WriteLine("Aluno Não Encontrado!");
            }
            else
            {
                Aluno aluno = Lista[i];
                Console.Write(
                    $"\n[ 1 ] Nome: {aluno.GetNome()}" +
                    $"\n[ 2 ] Matricula: {aluno.GetMatricula()}" +
                    $"\n[ 3 ] Idade: {aluno.GetIdade()} anos" +
                    $"\n[ 4 ] Curso: {aluno.GetCurso()}" +
                    $"\n[ 5 ] Período: {aluno.GetPeriodo()}º período" +
                    $"\n" +
                    $"\n[ 6 ] Disciplina: {aluno.GetDisciplinas().GetDisciplina()}" +
                    $"\n[ 7 ] Horario: {aluno.GetDisciplinas().GetHorario()} horas" +
                    $"\n[ 8 ] Creditos: {aluno.GetDisciplinas().GetCreditos()} créditos" +
                    $"\n" +
                    $"\n[ 9 ] País: {aluno.GetEndereço().GetPais()}" +
                    $"\n[ 10 ] Estado: {aluno.GetEndereço().GetEstado()}" +
                    $"\n[ 11 ] Cidade: {aluno.GetEndereço().GetCidade()}" +
                    $"\n[ 12 ] Bairro: {aluno.GetEndereço().GetBairro()}" +
                    $"\n[ 13 ] Rua: {aluno.GetEndereço().GetRua()}" +
                    $"\n[ 14 ] Número: {aluno.GetEndereço().GetNumero()}" +
                    $"\n[ 15 ] Complemento: {aluno.GetEndereço().GetComplemento()}" +
                    $"\n[ 16 ] CEP: {aluno.GetEndereço().GetCEP()}" +
                    $"\nDigite os dados do aluno {aluno.GetNome()} que você deseja que sejam alterados (separado por espaço): ");
                string[] ops_temp = Console.ReadLine().Trim().Split(' ');
                List<int> ops = new List<int> { };
                foreach (string c in ops_temp)
                {
                    ops.Add(int.Parse(c));
                }

                foreach (int j in ops)
                {
                    switch (j)
                    {
                        case 1:
                            Console.Write("\nDigite o Novo Nome do Aluno: ");
                            string nome = Console.ReadLine();
                            aluno.SetNome(nome);
                            Console.WriteLine("Nome Alterado Com Sucesso!");
                            break;

                        case 2:
                            Console.Write("\nDigite o Novo Número de Matrícula do Aluno: ");
                            int matricula = int.Parse(Console.ReadLine());
                            aluno.SetMatricula(matricula);
                            Console.WriteLine("Número de Matrícula Alterado Com Sucesso!");
                            break;

                        case 3:
                            Console.Write("\nDigite a Nova Idade do Aluno: ");
                            int idade = int.Parse(Console.ReadLine());
                            aluno.SetIdade(idade);
                            Console.WriteLine("Idade Alterada Com Sucesso!");
                            break;

                        case 4:
                            Console.Write("\nDigite o Novo Curso do Aluno: ");
                            string curso = Console.ReadLine();
                            aluno.SetCurso(curso);
                            Console.WriteLine("Curso Alterado Com Sucesso!");
                            break;

                        case 5:
                            Console.Write("\nDigite o Novo Período do Aluno: ");
                            int periodo = int.Parse(Console.ReadLine());
                            aluno.SetPeriodo(periodo);
                            Console.WriteLine("Período Alterado Com Sucesso!");
                            break;

                        case 6:
                            Console.Write("\nDigite a Nova Disciplina do Aluno: ");
                            string disciplina = Console.ReadLine();
                            aluno.GetDisciplinas().SetDisciplina(disciplina);
                            Console.WriteLine("Disciplina Alterada Com Sucesso!");
                            break;

                        case 7:
                            Console.Write("\nDigite o Novo Horário do Aluno: ");
                            string horario = Console.ReadLine();
                            aluno.GetDisciplinas().SetHorario(horario);
                            Console.WriteLine("Horário Alterado Com Sucesso!");
                            break;

                        case 8:
                            Console.Write("\nDigite o Novo Número de Créditos do Aluno: ");
                            int creditos = int.Parse(Console.ReadLine());
                            aluno.GetDisciplinas().SetCreditos(creditos);
                            Console.WriteLine("Crédito Alterado Com Sucesso!");
                            break;

                        case 9:
                            Console.Write("\nDigite o Novo País de Residência do Aluno: ");
                            string pais = Console.ReadLine();
                            aluno.GetEndereço().SetPais(pais);
                            Console.WriteLine("País de Residência Alterado Com Sucesso!");
                            break;

                        case 10:
                            Console.Write("\nDigite o Novo Estado de Residência do Aluno: ");
                            string estado = Console.ReadLine();
                            aluno.GetEndereço().SetEstado(estado);
                            Console.WriteLine("Estado de Residência Alterado Com Sucesso!");
                            break;

                        case 11:
                            Console.Write("\nDigite a Nova Cidade de Residência do Aluno: ");
                            string cidade = Console.ReadLine();
                            aluno.GetEndereço().SetCidade(cidade);
                            Console.WriteLine("Cidade de Residência Alterada Com Sucesso!");
                            break;

                        case 12:
                            Console.Write("\nDigite o Novo Bairro de Residência do Aluno: ");
                            string bairro = Console.ReadLine();
                            aluno.GetEndereço().SetBairro(bairro);
                            Console.WriteLine("Bairro de Residência Alterado Com Sucesso!");
                            break;

                        case 13:
                            Console.Write("\nDigite a Nova Rua de Residência do Aluno: ");
                            string rua = Console.ReadLine();
                            aluno.GetEndereço().SetRua(rua);
                            Console.WriteLine("Rua de Residência Alterada Com Sucesso!");
                            break;

                        case 14:
                            Console.Write("\nDigite o Novo Número da Rua de Residência do Aluno: ");
                            int numero = int.Parse(Console.ReadLine());
                            aluno.GetEndereço().SetNumero(numero);
                            Console.WriteLine("Número da Rua de Residência Alterado Com Sucesso!");
                            break;

                        case 15:
                            Console.Write("\nDigite o Novo Complemento do Aluno: ");
                            string complemento = Console.ReadLine();
                            aluno.GetEndereço().SetComplemento(complemento);
                            Console.WriteLine("Complemento Alterado Com Sucesso!");
                            break;

                        case 16:
                            Console.Write("\nDigite o Novo CEP do Aluno: ");
                            int cep = int.Parse(Console.ReadLine());
                            aluno.GetEndereço().SetCEP(cep);
                            Console.WriteLine("CEP Alterado Com Sucesso!");
                            break;

                        default:
                            Console.WriteLine($"\n\"{j}\" é Uma Opção Inválida!");
                            break;
                    }
                }
            }

            return Lista;
        }

        static List<Aluno> ExcluirAluno(List<Aluno> Lista)
        {
            Console.Write("Digite o Número de Matrícula do Aluno a ser Excluído: ");
            int matricula = int.Parse(Console.ReadLine());

            int i = -1;
            foreach (Aluno aluno in Lista)
            {
                if (matricula == aluno.GetMatricula())
                {
                    i = Lista.IndexOf(aluno);
                    break;
                }
            }

            if (i == -1)
            {
                Console.WriteLine("Aluno Não Encontrado!");
            }
            else
            {
                Lista.RemoveAt(i);
                Console.WriteLine("Aluno Removido Com Sucesso!");
            }

            return Lista;
        }
    }
}
