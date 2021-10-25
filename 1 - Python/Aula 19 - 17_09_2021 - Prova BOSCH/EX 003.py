dicionario = {}
gols = []
total = 0

nome = input('Digite o nome do jogador: ')
while True:
    try:
        partidas = int(input('Digite a quantidade de partidas jogadas: '))
    except ValueError:
        print('Valor inválido! Tente novamente.')
        continue
    if partidas <= 0:
        print('Valor inválido! Tente novamente.')
        continue
    break

dicionario['Nome'] = nome

for c in range(partidas):
    while True:
        try:
            quant = int(input(f'Quantos gols na partida {c+1}? '))
        except ValueError:
            print('Valor inválido! Tente novamente.')
            continue
        if quant < 0:
            print('Valor inválido! Tente novamente.')
            continue
        break
    gols.append(quant)
    total += quant
dicionario['Gols'] = gols
dicionario['Total'] = total

print(f'''
{dicionario}
O jogador {dicionario["Nome"]} jogou {len(dicionario["Gols"])} partidas.''')
x = 0
for gol in dicionario['Gols']:
    if gol == 1:
        print(f'Na partida {x+1} fez {gol} gol')
    else:
        print(f'Na partida {x+1} fez {gol} gols')
    x += 1
print(f'Com um total de {dicionario["Total"]} gols')
    