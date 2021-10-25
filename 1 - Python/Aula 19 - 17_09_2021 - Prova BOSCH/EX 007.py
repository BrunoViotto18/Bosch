def cifra(texto, cod):
    alpha = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
    codigo = ''
    for c in texto:
        x = (alpha.index(c) + cod) % 26
        codigo += alpha[x]
    return codigo

while True:
    try:
        cod = int(input('Qual o número para codificação? '))
    except ValueError:
        print('Valor inválido! Tente novamente.')
        continue
    break
txt = input('Insira a palavra a ser codificada: ')

print(f'\nCriptografia: {cifra(txt, cod)}')
