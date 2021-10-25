nome = input('Insira o nome do aluno: ')
curso = input('Insira o nome do curso: ')
while True:
    try:
        matricula = int(input('Insira o número da matrícula: '))
    except ValueError:
        print('Matrícula inválida! Tente novamente.')
        continue
    if matricula < 0:
        print('Matrícula inválida! Tente novamente.')
        continue
    break

try:
    arq = open('S:\\COM\\Human_Resources\\01.Engineering_Tech_School\\02.Internal\\10 - Aprendizes\\5 - Desenvolvimento de Sistemas\\Bruno Viotto Dos Santos\\Aula - 17_09_2021 - PROVA BOSCH\\arquivo.txt', 'a+')
    arq.write(f'{nome},{curso},{matricula}\n')
    print('Cadastro realizado!')
    arq.seek(0)
    print(f'Número de alunos cadastrados: {len(arq.readlines())}')
except:
    print('ERRO!')
finally:
    arq.close()

