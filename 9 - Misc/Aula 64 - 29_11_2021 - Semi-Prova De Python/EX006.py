import os

def cont(num):
    for i in range(num+1):
        print(f'{i}')
        print('-' * 50)


os.system('cls')

num = int(input('Digite um número: '))

os.system('cls')

cont(num)
