lista = ['1_palmeiras', '2_coritiba', '1_corintians', '3_juventude', '2_fluminense', '3_bahia', '1_cuiaba', '2_cascavel', '3_ponte preta', '2_parana clube', '3_volta redonda']
primeira = []
segunda = []
terceira = []

for c in lista:
    if c[0] == '1':
        primeira.append(c[2:])
    elif c[0] == '2':
        segunda.append(c[2:])
    elif c[0] == '3':
        terceira.append(c[2:])

print(f'''
Lista: {lista}\n
Primeira Divisão: {primeira}\n
Segunda Divisão: {segunda}\n
Terceira Divisão: {terceira}''')
