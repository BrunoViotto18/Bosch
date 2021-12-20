import pandas as pd
import matplotlib.pyplot

# Lê o csv, o grava em um dataframe, e o transforma em um dicionário
filename = r"exercicioedjalma.csv"
df = pd.read_csv(filename)
dicionario = df.to_dict()

# Adiciona todas as datas em uma lista
datas = []
for i in dicionario.keys():
    datas.append(i)
    for j in dicionario[i].values():
        datas.append(j)

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

for i in range(12):
    print(f'{i+1} - {dias.count(f"{i+1}")}')
