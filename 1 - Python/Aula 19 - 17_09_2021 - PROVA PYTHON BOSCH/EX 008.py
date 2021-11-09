import pandas as pd
import matplotlib.pyplot as plt

df = pd.read_csv('S:\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\10 - Aprendizes\5 - Desenvolvimento de Sistemas\Bruno Viotto Dos Santos\Aula - 17_09_2021 - PROVA BOSCH\netflix_titles.csv')
df = df.dropna()
df = df.loc[df['country'] == 'United States']
df = df.loc[df['release_year'] >= 2015]
df = df.loc[df['release_year'] <= 2020]
df = df['release_year'].value_counts()

ano2015 = df[2015]
ano2016 = df[2016]
ano2017 = df[2017]
ano2018 = df[2018]
ano2019 = df[2019]
ano2020 = df[2020]
anos = ['2015', '2016', '2017', '2018', '2019', '2020']
valores = [ano2015, ano2016, ano2017, ano2018, ano2019, ano2020]
plt.bar(anos, valores)
plt.xlabel('Anos')
plt.ylabel('Quant. de Filmes')
plt.title('Estatisticas de Filmes')
plt.show()
df = pd.read_csv('S:\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\10 - Aprendizes\5 - Desenvolvimento de Sistemas\Bruno Viotto Dos Santos\Aula - 17_09_2021 - PROVA BOSCH\netflix_titles.csv')
df = df.loc[df['country'] == 'Brazil']
df = df.sort_values(by='duration')
print(df.head(5))
