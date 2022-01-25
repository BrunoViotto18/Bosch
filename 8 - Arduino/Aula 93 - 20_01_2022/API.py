import requests
import json
import pyodbc
import time
import seaborn


proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'}
url = 'https://teste-912f4-default-rtdb.firebaseio.com/Sensor.json'

def sinal():
    proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'}
    url_temperatura = 'https://teste-912f4-default-rtdb.firebaseio.com/Sensor/temperatura.json'
    url_umidade = 'https://teste-912f4-default-rtdb.firebaseio.com/Sensor/umidade.json'
    temperatura = float(requests.get(url_temperatura, proxies=proxies).content)
    umidade = float(requests.get(url_umidade, proxies=proxies).content)
    return temperatura, umidade

def InserirBD(sinal):
    server = 'JVLPC0506'
    database = 'SensorBruno'
    username = 'bruno'
    password = 'admin'
    cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
    cursor = cnxn.cursor()
    cursor.execute(f"INSERT INTO dbo.Sensor (Temperatura, Umidade) VALUES ({sinal[0]}, {sinal[1]});")
    cursor.commit()
    print("Inserido com sucesso!")

'''while True:
    InserirBD(sinal())
    time.sleep(1)'''
    
def SelectBD():
    server = 'CTPC3621'
    database = 'Bruno_DB'
    username = 'bruno'
    password = 'admin'
    cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
    cursor = cnxn.cursor()
    cursor.execute(f"SELECT * FROM Sensor;")
    print(cursor.columns(table='Sensor'))
    for row in cursor.fetchall():
        print(row)
    
print(SelectBD())
    