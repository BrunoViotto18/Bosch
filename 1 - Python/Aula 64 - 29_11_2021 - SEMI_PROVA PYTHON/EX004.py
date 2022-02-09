print('Pressione * para parar\n')

lista = []
while True:
    num = input('Digite um número: ')
    if num == '*':
        break
    lista.append(int(num) * 2)

print(f'\nNúmeros: {lista}')
