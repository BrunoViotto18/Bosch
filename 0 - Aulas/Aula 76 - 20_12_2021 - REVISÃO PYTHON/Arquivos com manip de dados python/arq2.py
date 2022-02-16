import random
import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
import datetime
import os

times = [datetime.datetime.strptime(str(i), '%H') for i in range(24)]


def gerarArqCsv(num, file_name):
    temperatura = []
    horario = []
    for i in range(num):
        celsius = random.randint(0, 35)
        #if celsius < 10:
            #celsius = "0" + str(celsius)
        temperatura.append(int(celsius))
        hora = random.randint(0, 23)
        minuto = random.randint(0,59)
        horario.append(datetime.time(hora, minuto))

    array = np.column_stack((horario,temperatura))
    data = pd.DataFrame(data=array, columns=["Hora", "Temperatura"])
    data.to_csv(f"{file_name}.csv", index=False)
    print("Arquivo csv gerado pod usa")


def plotarGraf(file_name, x):
    
    for i in range(0, x):
        Dados = pd.DataFrame(pd.read_csv(f'{file_name}{i}.csv').sort_values(by=["Hora"]))
        with plt.style.context('Solarize_Light2'):
            plt.figure(figsize=(20,10))
            plt.title('Temperatura durante o dia')
            #plt.xticks(rotation='vertical')
            #print(times)
            plt.xlabel("Hora")
            plt.ylabel("Temperatura")
            plt.plot(Dados["Hora"], Dados["Temperatura"])
            plt.setp(plt.gca().xaxis.get_majorticklabels(),'rotation', 90)



def mostrar():
    plt.show()


def deletar(file_name):
    direc = fr"C:/Users/disrct/Desktop/testes/{file_name}"
    os.remove(direc)
