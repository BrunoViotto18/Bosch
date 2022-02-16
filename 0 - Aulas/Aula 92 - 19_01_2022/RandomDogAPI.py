import requests
import json


proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'}

url = 'https://teste-f8ac0-default-rtdb.firebaseio.com/Sensor/Temperatura.json'

temperatura = float(requests.get(url, proxies=proxies).content)

print(requests.get(url, proxies=proxies).content)

print(temperatura)
