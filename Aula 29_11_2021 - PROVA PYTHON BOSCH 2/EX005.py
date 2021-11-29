import os

os.system('cls')

print('Calculadora')

n1 = float(input('Digite um número: '))
n2 = float(input('Digite mais um número: '))

os.system('cls')

while True:
    print('Calculadora')
    print('[ 1 ] Somar')
    print('[ 2 ] Subtrair')
    print('[ 3 ] Multiplicar')
    print('[ 4 ] Dividir')
    print('[ 5 ] Novos números')
    print('[ 6 ] Sair')
    op = int(input('Escolha uma das opções: '))

    os.system('cls')

    if op == 1:
        print(f'{n1} + {n2} = {n1 + n2}\n')
    
    elif op == 2:
        print(f'{n1} - {n2} = {n1 - n2}\n')
    
    elif op == 3:
        print(f'{n1} * {n2} = {n1 * n2}\n')
    
    elif op == 4:
        print(f'{n1} / {n2} = {n1 / n2}\n')
    
    elif op == 5:
        n1 = float(input('Digite um número: '))
        n2 = float(input('Digite mais um número: '))
        continue
    
    elif op == 6:
        break

    else:
        print('Valor inválido! Tente novamente.\n')
    
    os.system('pause')
    os.system('cls')
