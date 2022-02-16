import paho.mqtt.client as mqtt
import time
import socket

import pyodbc
import json


socket.getaddrinfo('localhost', 8080)

def on_connect(client, userdata, flags, rc):
	if rc==0:
		print("Cliente conectado ao Broker!\n")
		try:
			client.subscribe("Treinamento/ets/bruno", qos=0)
			print("Cliente inscrito no tópico!\n")
         
		except:
			print("Não foi possível inscrever o cliente no tópico\n")
	else:
		print("Cliente não conectado ao Broker.\n")


def on_disconnect(client, userdata, rc):
	if rc != 0:
		print("Cliente desconectado do Broker inesperadamente.\n")	


def on_message(client, userdata, msg):
    info = json.loads(str(msg.payload.decode('utf-8')))
    InserirBD(info['humid'], info['temp'], info['ldr'])
    
    
    msgPayload = str(msg.payload.decode('utf-8'))
    #msgTopic = str(msg.topic)
    print(msgPayload + "\n")





def InserirBD(*info):
    server = 'CTPC3621'
    database = 'Bruno_DB'
    username = 'bruno'
    password = 'admin'
    cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
    cursor = cnxn.cursor()
    cursor.execute(f"INSERT INTO bruno.Sensor (temperatura, umidade, luminosidade) VALUES ({info[0]}, {info[1]}, {info[2]});")
    cursor.commit()
    print("Inserido com sucesso!")

'''while True:
    InserirBD(temperatura, humidade, luminosidade)
    time.sleep(1)'''





broker_address='broker.hivemq.com'
broker_port=1883


client = mqtt.Client()
client.on_connect = on_connect
client.on_disconnect = on_disconnect
client.on_message = on_message
print("Conectando ao Broker")
client.connect(broker_address, broker_port)
print("Broker!!")
time.sleep(4)
client.loop_forever()


