import matplotlib.pyplot as plt
import seaborn as sns
import pandas as pd
import numpy as np
import pyodbc


server = 'JVLPC0506'
database = 'SensorBruno'
username = 'bruno'
password = 'admin'
conn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
cursor = conn.cursor()
cursor.execute(f"SELECT Temperatura, timestamp FROM Sensor;")
row = cursor.fetchone()

lista = []
listatempo = []

while row:
    lista.append(row[0])
    listatempo.append(str(row[1]))
    row = cursor.fetchone()
    
df = pd.DataFrame({"Temperatura":lista, "Tempo":listatempo})

df['Tempo'] = pd.to_datetime(df['Tempo'])
sns.relplot(x='Tempo', y='Temperatura', data=df, kind='line')
plt.title('Temperatura por Tempo')
plt.xticks(rotation=90)
