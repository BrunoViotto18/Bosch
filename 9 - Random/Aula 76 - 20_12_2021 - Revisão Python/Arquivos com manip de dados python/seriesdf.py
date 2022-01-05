import pandas as pd
import numpy as np

array = ([1.7, 1.6, 1.5, 1.89, 0.9], [2, 3, 4 ,5 ,6])
serarr = pd.Series(array)
datarr = pd.DataFrame(array)

print(serarr)
print(datarr)

print("\n\n---------------------------------------\n\n")

A = {'a': 1, 'b': 2, 'c': 3, 'd': np.nan}
B = [-10, 2, -1]

ser1 = pd.Series(A)
ser2 = pd.Series(B, index=['a', 'b', 'c'], dtype=float)

ser1.iloc[0] = 999

ser1 = ser1.add(ser2, fill_value=0)
print(f"Series 1 após o add: \n{ser1}")

print("\n\n---------------------------------------\n\n")

ser1 = ser1.multiply(3)
print(f"Series 1 após o multiply: \n{ser1}")

print("\n\n---------------------------------------\n\n")

ser1 = ser1.divide(2.4)
print(f"Series 1 após o divide: \n{ser1}")

print("\n\n---------------------------------------\n\n")

dict = {'a': [2,3], 'b': [4,3], 'c': [4,6], 'd': [3,6]}

dat1 = pd.DataFrame(dict)
print(f"Dataframe de boas: \n{dat1}")
print("\n")
dat1 = dat1.multiply(3)
print(f"Dataframe dps do multiply: \n{dat1}")
print("\n")
dat1.iloc[0][1] = 999
print(f"Dataframe dps de usar o iloc no index 0,1: \n{dat1}")