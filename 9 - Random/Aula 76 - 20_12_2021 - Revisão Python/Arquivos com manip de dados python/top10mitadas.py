import pandas as pd
import matplotlib.pyplot as plt
import random

idade = []
sexo = []
sexos = ["M", "F"]
dictio = {"Idade": idade, "Sexo": sexo}

for i in range(250):
    aux2 = random.randint(0,1)
    sexo.append(sexos[aux2])
    if aux2 == 0:
            aux1 = random.randint(18, 22)
            idade.append(aux1)
    else:
            aux1 = random.randint(16, 20)
            idade.append(aux1)


df = pd.DataFrame(dictio)
print(df)

ValIdades = [18, 19, 20, 21, 22]

ValIdades2 = [16, 17, 18.25, 19.25, 20.25]  
 
'''
ValIdades2 = []
for i in ValIdades:
    ValIdades2.append(i+0.25-2)   # Solução bruno
'''


with plt.style.context('Solarize_Light2'):
    plt.figure(figsize=(20,10))
    fig = plt.figure()
    ax = fig.add_axes([0,0,1,1])
    ax.set_xlabel("Idade")
    ax.set_ylabel("Quantidade")
    ax.set_title('Pessoas com X anos de idade')
    ax.bar(ValIdades, height = df["Idade"].loc[df['Sexo'] == "M"].value_counts().sort_index(),width = 0.25, color='b')
    ax.bar(ValIdades2, height = df["Idade"].loc[df['Sexo'] == "F"].value_counts().sort_index(),width = 0.25, color='r')
    
    """ # solução antiga do murilo
    ax.bar(df["Idade"].unique(), height = df["Idade"].loc[df['Sexo'] == "M"],width = 0.25, color='b')
    ax.bar(df["Idade"].unique() + 0.25, height = df["Idade"].loc[df['Sexo'] == "F"],width = 0.25, color='r')   # Solução reflexão banheiro
    """
    
    ax.legend(labels=['os guri', 'as guria'])
    
    
plt.show()
print(df["Idade"].loc[df["Sexo"] == "M"].value_counts())
print(df["Idade"].loc[df["Sexo"] == "F"].value_counts())
print(df["Idade"].value_counts())