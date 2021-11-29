import pandas as pd
import os

os.system('cls')

def separator(dataFrame, i):
    flag = False
    txt = ''
    year = ''
    for j in dataFrame[i]:
        if not flag:
            if j.isdigit():
                flag = True
                year += j
                continue
            txt += j
        else:
            year += j
    return [txt, year]
            

df = pd.read_csv('datas.csv')
country_year = df['country-year']
df.drop('country-year', axis='columns', inplace=True)
lista = [[], []]

for i in range(len(country_year)):
    lista2 = separator(country_year, i)
    lista[0].append(lista2[0])
    lista[1].append(lista2[1])


df.insert(5, 'country', lista[0])
df.insert(6, 'year', lista[1])

df.drop('HDI for year', axis='columns', inplace=True)

df = df.loc[df['country'] == 'Brazil']
df = df.loc[df['year'] == '1987']
df = df.loc[df['sex'] == 'female']
df = df.loc[df['generation'] == 'Boomers']

print(df)
