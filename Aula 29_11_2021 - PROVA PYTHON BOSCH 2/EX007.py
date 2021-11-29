import os

os.system('cls')

try:
    arq = open('questao_7.txt', 'a')

    txt = input('Digite algo: ')

    arq.write(f'{txt}\n')

    print('String salva no arquivo com sucesso!')

except Exception:
    print('Erro!')

finally:
    arq.close()
