import matplotlib.pyplot as plt
import seaborn as sns
import pandas as pd
import pyodbc


server = 'CTPC3621'
database = 'Bruno_DB'
username = 'bruno'
password = 'admin'
conn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
cursor = conn.cursor()
cursor.execute(f"SELECT luminosidade, horario FROM Sensor;")
row = cursor.fetchone()

lista = []
listatempo = []

while row:
    lista.append(row[0])
    listatempo.append(str(row[1]))
    row = cursor.fetchone()
    
df = pd.DataFrame({"Luminosidade":lista, "Tempo":listatempo})

df['Tempo'] = pd.to_datetime(df['Tempo'])
sns.relplot(x='Tempo', y='Luminosidade', data=df, kind='line')
plt.title('Luminosidade por Tempo')
plt.xticks(rotation=90)
