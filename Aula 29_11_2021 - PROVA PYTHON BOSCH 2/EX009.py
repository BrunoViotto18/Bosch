import os
import math

def isPrime(num):
    if num < 2:
        return False
    if num == 2:
        return True
    for i in range(1, math.ceil(math.sqrt(num)+1)):
        if num % i == 0:
            return False
    return True


while True:
    num = int(input('Digite um Número: '))
    if isPrime(num):
        print(f'{num} é um número primo!\n')
        break
    print(f'{num} não é um número primo.\n')
