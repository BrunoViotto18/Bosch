import requests
import pyodbc
import time


def valores():
    proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'}
    url_luminosidade = 'https://sensorldr-16e00-default-rtdb.firebaseio.com/Sensor/luminosidade.json'
    luminosidade = float(requests.get(url_luminosidade, proxies=proxies).content)
    return luminosidade


def InserirBD(valores):
    server = 'CTPC3621'
    database = 'Bruno_DB'
    username = 'bruno'
    password = 'admin'
    cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
    cursor = cnxn.cursor()
    cursor.execute(f"INSERT INTO dbo.Sensor (luminosidade) VALUES ({valores});")
    cursor.commit()
    print("Inserido com sucesso!")


while True:
    InserirBD(valores())
    time.sleep(15)
