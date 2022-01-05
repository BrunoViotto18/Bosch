import arq2 as FF
import pandas as pd

qntLoop = int(input("Digite quantos dias estão sendo validados: "))
nome = input("Nome do arquivo csv gerado: ")
for i in range(0, qntLoop):
    qntDados = int(input("Digite a quantidade de dados a serem gerados: "))
    nomeArq = nome+f"{i}"
    FF.gerarArqCsv(qntDados, nomeArq)

FF.plotarGraf(nome, qntLoop)

FF.mostrar()

df = pd.DataFrame(pd.read_csv(f'{nome}0.csv').sort_values(by=["Hora"]))
print(df)
for i in range(0, qntLoop):
    FF.deletar(nome+f"{i}.csv")