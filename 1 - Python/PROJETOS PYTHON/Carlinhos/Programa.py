import colorama

colorama.init()

def getCollumnIndex(arq, coluna:str) -> int:
    arq.seek(0)
    linha = arq.readline()
    if (coluna not in linha):
        return -1
    index = linha.index(coluna)
    counter = 1
    for i in range(0, index):
        if linha[i] == ';':
            counter += 1
    return counter


def getLineItem(arq, linha:int, coluna:str) -> str:
    index = getCollumnIndex(arq, coluna)
    arq.seek(0)
    for c in range(0, linha):
        linha = arq.readline()
    for c in range(index-1):
        indice = linha.index(';')
        linha = linha[indice+1:]
    string = ''
    for c in linha:
        if c == ';' or c == '\n':
            break
        string += c
    return string


def getCollumns(arq, *colunas) -> list:
    lista = []
    for c in range(0, len(colunas)):
        arq.seek(0)
        coluna = []
        for i in range(2, len(arq.readlines())+1):
            coluna.append(getLineItem(arq, i, colunas[c]))
        lista.append(coluna[:])
    return lista


def main():
    try:
        arq = open("Arquivo.csv", 'rt+')

        #EX001
        lista = getCollumns(arq, 'marca', 'preco US$')
        marcas = lista[0]
        precos = lista[1]
        media = {}

        for i in range(0, len(marcas)):
            if marcas[i] not in media.keys():
                media[marcas[i]] = int(precos[i])
            else:
                media[marcas[i]] += int(precos[i])
        
        flag = True
        for k, v in media.items():
            media[k] = int(v) / marcas.count(k)
            if flag:
                flag = False
                menor = k
                menorv = media[k]
            elif media[k] < menorv:
                menor = k
                menorv = media[k]

        print("\n\033[1;35mEX001\033[m")
        print(f"Marca com valor médio mais baixo: '{menor}'\n")

        #EX002
        lista = getCollumns(arq, 'marca', 'estiloCarroc', 'cavalosPot', 'milhas por galao(cidade)', 'milhas por galao(estrada)')
        carros = [[], [], [], [], []]
        for i in range(len(lista[0])):
            if int(lista[4][i]) - int(lista[3][i]) < 2:
                for j in range(5):
                    carros[j].append(lista[j][i])
        
        print("\033[1;35mEX002\033[m")
        if len(carros[0]) == 0:
            print("Não há carros com uma diferença de milhas por galão (estrada - cidade) inferior a 2!\n")
        else:
            print("Carros com uma diferença de milhas por galão (estrada - cidade) inferior a 2:\n")
            for i in range(len(carros[0])):
                print(f"Marca: {carros[0][i]} \nEstilo: {carros[1][i]} \nPotência(cavalos): {carros[2][i]}\n")
        
        #EX003
        lista = getCollumns(arq, 'marca', 'tipoComb')
        dicionario = {}
        for i in range(len(lista[0])):
            if lista[0][i] not in dicionario.keys():
                dicionario[lista[0][i]] = [lista[1][i]]
            else:
                dicionario[lista[0][i]].append(lista[1][i])
        
        marcas = []
        for k, v in dicionario.items():
            gas = 0
            diesel = 0
            for valor in dicionario[k]:
                if valor == 'Gas':
                    gas += 1
                else:
                    diesel += 1
            if diesel > gas:
                marcas.append(k)
        
        print("\033[1;35mEX003\033[m")
        if len(marcas) == 0:
            print("Não há marcas que utilizem diesel como combustível principal ou mais usado!")
        else:
            print("Marcas que utilizam diesel como combustível principal ou mais usado: \n")
            for i in range(len(marcas)):
                print(f"{i+1} - {marcas[i]}")
        print()

    except Exception:
        print("Erro inesperado!")
        
    finally:
        arq.close()


if __name__ == '__main__':
    main()
