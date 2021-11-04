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
    for c in range(0, linha-1):
        arq.readline()
    linha = arq.readline()
    for c in range(index-1):
        indice = linha.index(';')
        linha = linha[indice+1:]
    string = ''
    for c in linha:
        if c == ';':
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
        print(coluna, "AAAA")
    return lista


def main():
    #try:
        arq = open("Arquivo.csv", 'rt+')
        #EX001
        lista = getCollumns(arq, 'marca', 'preco US$')
        print(lista)
        marcas = lista[0]
        precos = lista[1]
        media = {}
        print(getLineItem(arq, 2, 'preco US$'))
        print(len(marcas))
        print(len(precos))
        for i in range(0, len(marcas)):
            if marcas[i] not in media.keys():
                media[marcas[i]] = precos[i]
        print(media)

    #except Exception:
        #print("Erro inesperado!")
        
    #finally:
        arq.close()


if __name__ == '__main__':
    main()
