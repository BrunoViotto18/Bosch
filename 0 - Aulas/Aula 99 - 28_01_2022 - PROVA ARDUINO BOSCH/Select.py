import matplotlib.pyplot as plt
import seaborn as sns
import pandas as pd
import pyodbc


server = 'CTPC3621'
database = 'Bruno_DB'
username = 'bruno'
password = 'admin'
conexao = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
cursor = conexao.cursor()
cursor.execute("SELECT temperatura, umidade, horario FROM Sensor");
linha = cursor.fetchone()

temperatura = []
umidade = []
tempo = []

while (linha):
    temperatura.append(float(linha[0]))
    umidade.append(float(linha[1]))
    tempo.append(str(linha[2]))
    linha = cursor.fetchone()
    

df = pd.DataFrame({'Temperatura': temperatura, 'Tempo': tempo})
df['Tempo'] = pd.to_datetime(df['Tempo'])
sns.relplot(x='Tempo', y='Temperatura', data=df, kind='line')
plt.title('Temperatura por Tempo')
plt.xticks(rotation=90)


df = pd.DataFrame({'Umidade': umidade, 'Tempo': tempo})
df['Tempo'] = pd.to_datetime(df['Tempo'])
sns.relplot(x='Tempo', y='Umidade', data=df, kind='line')
plt.title('Umidade por Tempo')
plt.xticks(rotation=90)

conexao = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
cursor = conexao.cursor()
cursor.execute("SELECT temperatura, umidade, horario FROM Sensor");
dados = cursor.fetchall()

print(f'\nQuantidade de dados: {len(dados)}')
