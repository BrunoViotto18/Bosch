import math

def Bhaskara(a, b, c):
    if a == 0:
        a = 1
    
    delta = b ** 2 - 4 * a * c
    
    if delta < 0:
        return False
    
    elif delta == 0:
        x = [(-b) / (2 * a)]
        return x
    
    elif delta > 0:
        x1 = (-b + math.sqrt(delta)) / (2 * a)
        x2 = (-b - math.sqrt(delta)) / (2 * a)
        lista = [x1, x2]
        return lista
    

print(f'{" BHASKARA ":=^30}')
while True:
    try:
        a = float(input('Digite o valor A: '))
    except ValueError:
        print('Valor inválido! Tente novamente.')
        continue
    break

while True:
    try:
        b = float(input('Digite o valor B: '))
    except ValueError:
        print('Valor inválido! Tente novamente.')
        continue
    break

while True:
    try:
        c = float(input('Digite o valor C: '))
    except ValueError:
        print('Valor inválido! Tente novamente.')
        continue
    break

x = Bhaskara(a, b, c)

if x == False:
    print('\nNão há raizes')
elif len(x) == 1:
    print('\nTeremos 1 raiz')
    print(f'A raiz é: {x[0]}')
elif len(x) == 2:
    print('\nTeremos 2 raizes')
    print(f'As raizes são: {x[0]} e {x[1]}')
    