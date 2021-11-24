from kafka import KafkaConsumer
import pandas as pd
import matplotlib.pyplot as plt
import json

consumer = KafkaConsumer('testCt-2', group_id='Bruno', bootstrap_servers='[ct-br.exaas.bosch.com:9092]')


try:
    arq = open('Arquivo.csv', 'rt+')
    
    '''lista = []
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
        arq.write(f'{c}\n')'''
        
    df = pd.read_csv(arq, sep=';')
    print(df['temp'])

except Exception:
    print('Erro!')

finally:
    arq.close()
