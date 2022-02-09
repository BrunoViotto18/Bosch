import requests
import pyodbc
import time


def valores():
    proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'}
    url_temperatura = 'https://prova-6d5e2-default-rtdb.firebaseio.com/Sensor/temperatura.json'
    url_umidade = 'https://prova-6d5e2-default-rtdb.firebaseio.com/Sensor/umidade.json'
    temperatura = float(requests.get(url_temperatura, proxies=proxies).content)
    umidade = float(requests.get(url_umidade, proxies=proxies).content)
    return temperatura, umidade
    

def InserirDB(valores):
    server = 'CTPC3621'
    database = 'Bruno_DB'
    username = 'bruno'
    password = 'admin'
    conexao = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
    cursor = conexao.cursor()
    cursor.execute(f'INSERT INTO dbo.Sensor (temperatura, umidade) VALUES ({valores[0]}, {valores[1]})')
    cursor.commit()
    print('Dados inseridos com sucesso!')


while(True):
    InserirDB(valores())
    time.sleep(1)
