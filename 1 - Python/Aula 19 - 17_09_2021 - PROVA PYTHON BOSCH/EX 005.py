import random

escolha = ['Pedra', 'Papel', 'Tesoura']
con = 1
maquina = usuario = 0


while con == 1:
    print('\nEscolha a sua jogada:')
    print('[ 1 ] Pedra')
    print('[ 2 ] Papel')
    print('[ 3 ] Tesoura')
    while True:
        user = input('Sua escolha: ')
        if user == '1' or user == '2' or user == '3':
            user = int(user)
            break
        print('Valor inválido! Tente novamente.')
    pc = random.randint(1, 3)

    print(f'Jogada máquina: {escolha[pc-1]}')
    if user == pc:
        print('Empate!')
    elif (user == 1 and pc == 2) or (user == 2 and pc == 3) or (user == 3 and pc == 1):
        print('Você perdeu!')
        maquina += 1
    elif (user == 1 and pc == 3) or (user == 2 and pc == 1) or (user == 3 and pc == 2):
        print('Você ganhou!')
        usuario += 1

    while True:
        con = input('Digite 1 para continuar jogando ou 0 para parar: ')
        if con == '0' or con == '1':
            con = int(con)
            break
        print('Valor inválido! Tente novamente.')

print(f'\nSeu score: {usuario}')
print(f'Score máquina: {maquina}')
    