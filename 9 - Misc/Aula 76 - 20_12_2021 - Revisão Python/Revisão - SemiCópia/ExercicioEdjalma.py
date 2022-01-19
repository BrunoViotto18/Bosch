#import pandas as pd
import matplotlib.pyplot as plt

def bubbleSort(lista, listaCount):
    for i in range(len(lista)):
        for j in range(len(lista)):
            if int(lista[int(i)]) < int(lista[int(j)]):
                lista[int(i)], lista[int(j)] = lista[int(j)], lista[int(i)]
                listaCount[int(i)], listaCount[int(j)] = listaCount[int(j)], listaCount[int(i)]
    return (lista, listaCount)


def listaCounter(listas):
    lista = []
    listaCount = []
    for i in listas:
        if i not in lista:
            lista.append(i)
            listaCount.append(1)
            continue
        listaCount[lista.index(i)] += 1
    lista, listaCount = bubbleSort(lista, listaCount)
    return (lista, listaCount)


filename = r"exercicioedjalma.csv"

# Lê o csv, o grava em um dataframe, e o transforma em um dicionário (Pandas)
'''df = pd.read_csv(filename)
dicionario = df.to_dict()'''

# Adiciona todas as datas em uma lista (Pandas)
'''datas = []
for i in dicionario.keys():
    datas.append(i)
    for j in dicionario[i].values():
        datas.append(j)'''

# Armazena as linhas/datas do arquivo dentro de uma lista
datas = []
with open(filename, 'rt+') as arq:
    for i in arq:
        datas.append(i)
    
# Divide e armazena as datas em suas respectivas listas
anos = []
meses = []
dias = []
for data in datas:
    data = data.split('/')
    if data[0][0] == '0':
        data[0] = data[0][1:]
    if data[1][0] == '0':
        data[1] = data[1][1:]
    dias.append(data[0])
    meses.append(data[1])
    anos.append(data[2])

# Armazena os dias e suas respectivas quantidades em duas listas
'''dia = []
diaCount = []
for i in dias:
    if i not in dia:
        dia.append(i)
        diaCount.append(1)
        continue
    diaCount[dia.index(i)] += 1
dia, diaCount = bubbleSort(dia, diaCount)'''

dia, diaCount = listaCounter(dias)
mes, mesCount = listaCounter(meses)
ano, anoCount = listaCounter(anos)
    
# Armazena os meses e suas respectivas quantidades em duas listas
'''mes = []
mesCount = []
for i in meses:
    if i not in mes:
        mes.append(i)
        mesCount.append(1)
        continue
    mesCount[mes.index(i)] += 1
mes, mesCount = bubbleSort(mes, mesCount)'''
    
# Armazena os anos e suas respectivas quantidades em duas listas
'''ano = []
anoCount = []
for i in anos:
    if i not in ano:
        ano.append(i)
        anoCount.append(1)
        continue
    anoCount[ano.index(i)] += 1
ano, anoCount = bubbleSort(ano, anoCount)'''


# Plota o gráfico dos dias
with plt.style.context('Solarize_Light2'):
    plt.figure(figsize=(15, 5)) 
    plt.bar(dia, diaCount)
    plt.title('Quantidade de cada dia')
    plt.xlabel('Dias')
    plt.ylabel('Quantidade')
    plt.show()


# Plota o gráfico dos meses
with plt.style.context('Solarize_Light2'):
    plt.figure(figsize=(10, 5)) 
    plt.bar(mes, mesCount)
    plt.title('Quantidade de cada mês')
    plt.xlabel('Meses')
    plt.ylabel('Quantidade')
    plt.show()


# Plota o gráfico dos anos
with plt.style.context('Solarize_Light2'):
    plt.figure(figsize=(30, 5)) 
    plt.bar(ano, anoCount)
    plt.title('Quantidade de cada ano')
    plt.xlabel('Anos')
    plt.ylabel('Quantidade')
    plt.show()
    