from kafka import KafkaConsumer
import pandas as pd
import matplotlib.pyplot as plt
import json


def getCollumnIndex(arq, coluna:str) -> int:
    arq.seek(0)
    linha = arq.readline()
    if (coluna not in linha):
        return -1
    index = linha.index(coluna)
    counter = 1
    for i in range(0, index):
        if linha[i] == ';':
            counter += 1
    return counter


def getLineItem(arq, linha:int, coluna:str) -> str:
    index = getCollumnIndex(arq, coluna)
    arq.seek(0)
    for c in range(0, linha):
        linha = arq.readline()
    for c in range(index-1):
        indice = linha.index(';')
        linha = linha[indice+1:]
    string = ''
    for c in linha:
        if c == ';' or c == '\n':
            break
        string += c
    return string


def getCollumns(arq, *colunas) -> list:
    lista = []
    for c in range(0, len(colunas)):
        arq.seek(0)
        coluna = []
        for i in range(2, len(arq.readlines())+1):
            coluna.append(getLineItem(arq, i, colunas[c]))
        lista.append(coluna[:])
    return lista


consumer = KafkaConsumer('testCt-ETS', group_id='ntuser', bootstrap_servers='[ct-br.exaas.bosch.com:9092]')

try:
    arq = open('Arquivo.csv', 'rt+')
    
    lista = []
    for msg in consumer:
        
        msg = msg.value.decode('utf-8')
        msg = msg[1:-1]
        msg = msg.replace('"', '')
        msg = msg.replace(", ", ";")
        msg = msg.replace("time: ", "")
        msg = msg.replace("temp: ", "")
        msg = msg.replace("air_pressure: ", "")
        msg = msg.replace("humidity: ", "")
        msg = msg.replace("product: ", "")
        msg = msg.replace("station: ", "")
        
        lista.append(msg)
        
        if len(lista) == 10:
            break

    arq.write('time;temp;air-pressure;humidity;product;station\n')
    for c in lista:
        arq.write(f'{c}\n')
        
    df = pd.read_csv(arq, sep=';')
    print(df['temp'])

except Exception:
    print('Erro!')

finally:
    arq.close()
