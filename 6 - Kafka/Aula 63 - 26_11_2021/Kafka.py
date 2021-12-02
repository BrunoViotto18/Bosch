import pandas as pd
import kafka as kf
import json
import time
import os


def send_to_broker(topic, message):
    producer.send(topic, message)
    #print(producer.metrics)


path = 'S:/COM/Human_Resources/01.Engineering_Tech_School/02.Internal/10 - Aprendizes/5 - Desenvolvimento de Sistemas/datastream/bruno/stat010'
broker = 'ct-br.exaas.bosch.com:9092'
topic = 'testCt-ETS'
producer = kf.KafkaProducer(bootstrap_servers=broker, value_serializer=lambda v: json.dumps(v).encode('utf-8'))

dicionario = {'Teste': 'Teste'}
send_to_broker(topic, dicionario)

while True:
    files = os.listdir(path)
    
    for file in files:
        fileName = os.path.join(path, file)
        
        data = pd.read_csv(fileName)
        
        data = data.to_dict()
        
        for k, v in data.items():
            data[k] = data[k][0]
        
        data['ntuser'] = 'Bruno'
        
        send_to_broker(topic, data)
        
        print(data)
        
        os.remove(fileName)
        
        time.sleep(0.5)


