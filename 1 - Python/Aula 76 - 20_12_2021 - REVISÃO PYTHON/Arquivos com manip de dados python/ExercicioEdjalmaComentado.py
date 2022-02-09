import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from openpyxl.workbook import Workbook  # Esse import aqui existe só pra criar o arquivo excel no final

# o parâmetro "sep" na função read_csv determina qual é o separador do arquivo, neste caso, é o "/"
read = pd.read_csv("exedj.csv", sep="/", names=["Dia", "Mês", "Ano"])   # Declaração das colunas direto no import..
# print(read) # Print pra ver como que tá o read                        # ..através do names=[]

repet = read.value_counts() # value_counts() retorna um dataframe referente à qntd de vezes que cada item..
# print(repet)              # ..único apareceu (e.g. [batata, batata] = batata | 2)

nivers = read.loc[(read["Dia"] == 14) & (read["Mês"] == 4)] # loc (de localizar (acho)) retorna os itens que se..
# print(nivers)                         # ..encaixam na condição estabelecida dentro dos colchetes, nesse caso..
                                        # ..itens da coluna "Dia" com valor 14 **E** (definido pelo &) itens da..
                                        # ..coluna "Mês" com o valor 4 (meu aniversário gente)

# Criação do dataframe copacamp, com a adição das colunas "Titulos do Brasil" e "Presidente", por nenhuma razão em..
# ..especifico, os valores já existentes vem do dataframe inicial (read), e, por fim, o dataframe é ordenado por ano
copacamp = pd.DataFrame(read, columns=["Dia", "Mês", "Ano", "Titulos do Brasil", "Presidente"]).sort_values(by="Ano")

copacamp = copacamp.replace({'Titulos do Brasil': np.nan}, 0)
# O comando .replace({dicionário}) possibilita a substituição de todos os valores de uma coluna, nesse caso, a troca..
# .. dos valores NaN (referenciados com a função nan do numpy) por 0
copacamp = copacamp.replace({'Presidente': np.nan}, "n lembro")
# Mesma coisa nesse aqui, porém desta vez colcamos "n lembro" ao invés de 0 para mostrar que somos muito bons em..
# ..história

# Esse for in range vai "inserir" o número de titulos do Brasil nos respectivos anos
for i in range(0, 5):
    anosTitul = [1958, 1962, 1970, 1994, 2002]  # Lista de anos onde o Brasil foi campeão
    titulos = [1, 2, 3, 4, 5]   # Lista com número de títulos, alternativamente pode-se apenas usar i+1
    copacamp["Titulos do Brasil"] = np.where(copacamp["Ano"] >= anosTitul[i], titulos[i], copacamp["Titulos do Brasil"])
    # Nessa linha de código, fazemos com que os itens da coluna "Titulos do Brasil" sejam substituidos pelo valor..
    # ..referente ao número de títulos. Porém, como o título permanece após ser adquirido, precisamos inserir o..
    # ..mesmo nos anos entre um título e outro, para isso usamos a função "where" do numpy.
    # np.where(Item_Da_Coluna >= Número_Comparação, Valor_Para_inserir, Coluna_onde_Inserir)
    # por exemplo:
    # np.where(Ano >= 1958, 1, Titulo)
    # Basicamente essa função do numpy vai fazer com que tudo acima do valor comparado se torne o valor desejado
    # Isso vai acontecer toda vez que um novo valor for adicionado, assim sobrescrevendo o anterior.

# Mesma coisa do de cima porém dessa vez para os presidentes
for i in range(0, 4):
    anosPres = [2002, 2010, 2016, 2018]
    presidentes = ["Lula", "Dilma", "Temer", "Bolsonaro"]
    copacamp["Presidente"] = np.where(copacamp["Ano"] >= anosPres[i], presidentes[i], copacamp["Presidente"])

# Print do copacamp, usando a função loc para imprimir todos os anos em que o brasil adiquiriu um título
# O "|" funciona como um "OR"
print(copacamp.loc[(copacamp["Ano"] == 1958) | (copacamp["Ano"] == 1962)
      | (copacamp["Ano"] == 1970) | (copacamp["Ano"] == 1994) | (copacamp["Ano"] == 2002)])

# style.context é só pra pegar um tema pré-definido
with plt.style.context('Solarize_Light2'):
    plt.figure(figsize=(20, 10))    # Declaração do tamanho da figura (x=20, y=10)
    plt.title('Prova definitiva de que eleger o Lula faz o Brasil virar Hexa')  # Título do gráfico
    plt.xticks(rotation='vertical') # Definindo os marcadores do eixo X como vertical
    plt.yticks([1,2,3,4,5], [1,2,3,4,5])    # Especificando no eixo Y que existem 5 marcadores, com legenda de..
                                            # ..1 até 5

    plt.xlabel("Ano")   # Declarando o eixo X como "Ano"
    plt.ylabel("Titulos")   # Declarando o eixo Y como "Títulos"
    plt.plot(copacamp["Ano"], copacamp["Presidente"] == "Lula",  'r', label="Presidente", linewidth=3)
    # Plotando a linha do presidente, X = Coluna Ano, Y = Coluna Presidente onde Presidente = Lula,..
    # ..cor da linha vermelha ('r'), com a label "Presidente" para aparecer na legenda do gráfico. Tamanho de linha 3.

    plt.text(2001, 1, 'Lula', horizontalalignment='right', fontsize=16, color='r', fontweight="bold")
    # Criação de um ponto com texto na posição X=2001 Y=1, alinhado para aparecer à esquerda do ponto(sim o right..
    # ..faz ele aparecer na esquerda), tamanho de fonte 16, cor vermelha, """peso""" da fonte como negrito.

    plt.plot(copacamp["Ano"], copacamp["Titulos do Brasil"], 'g', label="Titulos do Brasil", linewidth=3)
    # Mesmo esquema da linha do presidente, mas dessa vez para os títulos do brasil, pintado de verde para diferenciar

    plt.text(2001, 5, 'Penta do Brasil', horizontalalignment='right', fontsize=16, color='g', fontweight="bold")
    # Mesmo esquema² do ponto para o presidente, única diferença sendo a cor e o valor Y. Y=5

    plt.axvline(2002, color='k', linestyle='dashed', linewidth=1)
    # Criação de uma linha vertical no ponto 2002, da cor preta ('k'), com estilo tracejado e tamanho 1
    """
    for x, y in zip(copacamp["Ano"], copacamp["Presidente"]):
        plt.annotate("{:}".format(y),  # this is the text
                     (x, y),  # these are the coordinates to position the label
                     textcoords="offset points",  # how to position the text
                     xytext=(0, 10),  # distance from text to points (x,y)
                     ha='center')  # horizontal alignment can be left, right or center
    """ # Esse bloco de código mostra o valor de cada ponto da linha na própria linha, porém já que a linha..
        # ..vai de 1950 até 2002, fica muito lotado de informação que não é relevante

    plt.legend()    # .legend() gera a legenda em algum canto não preenchido da tela, porém é possível especificar..
                    # ..em qual canto gerar ela
    plt.show()  # .show() só mostra o gráfico mesmo

#print(copacamp)    # Print do dataframe final
copacamp.to_excel("EleicaoCopa.xlsx")   # Criar um arquivo excel do dataframe
