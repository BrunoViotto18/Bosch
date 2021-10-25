def date(data):
    data = data.split(' de ')
    meses = ['janeiro', 'fevereiro', 'março', 'abril', 'maio', 'junho', 'julho', 'agosto', 'setembro', 'outubro', 'novembro', 'dezembro']
    if len(data) != 3:
        return False
    if data[1] not in meses:
        return False
    if data[0].isnumeric() == False:
        return False
    if data[2].isnumeric() == False:
        return False
    
    if int(data[0]) < 10:
        dia = f'0{data[0]}'
    else:
        dia = f'{data[0]}'
        
    indice = meses.index(data[1])
    if indice+1 < 10:
        mes = f'0{indice+1}'
    else:
        mes = f'{indice+1}'
        
    ano = f'{data[2]}'
    return f'{dia}/{mes}/{ano}'


data = input('Digite a data atual (ex: 14 de Julho de 2020): ').strip().lower()

if date(data) == False:
    print('\nModelo de data inválido!')
else:
    print(f'\n{date(data)}')
