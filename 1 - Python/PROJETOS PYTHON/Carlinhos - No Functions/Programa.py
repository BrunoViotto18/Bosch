try:
    arq = open("Arquivo.csv", 'rt+')

    #EX001
    ccolunas = ['marca', 'preco US$']
    clista = []
    for a in range(0, len(ccolunas)):
        arq.seek(0)
        ccoluna = []
        for b in range(2, len(arq.readlines())+1):
            arq.seek(0)
            alinha = arq.readline()
            if (ccolunas[a] not in alinha):
                acounter = -1
            for c in range(len(alinha)):
                if alinha[c:c+len(ccolunas[a])] == ccolunas[a]:
                    aindex = c
                    break
            acounter = 1
            for d in range(0, aindex):
                if alinha[d] == ';':
                    acounter += 1
            bindex = acounter
            arq.seek(0)
            blinha = b
            for e in range(0, blinha):
                blinha = arq.readline()
            for f in range(bindex-1):
                for g in range(len(blinha)):
                    if blinha[g] == ';':
                        bindice = g
                        break
                blinha = blinha[bindice+1:]
            bstring = ''
            for h in blinha:
                if h == ';' or h == '\n':
                    break
                bstring += h
            ccoluna.append(bstring)
        clista.append(ccoluna[:])

    lista = clista
    marcas = lista[0]
    precos = lista[1]
    media = [[], []]

    for i in range(0, len(marcas)):
        if marcas[i] not in media[0]:
            media[0].append(marcas[i])
            media[1].append(int(precos[i]))
        else:
            for j in range(0, len(marcas)):
                if marcas[i] == media[0][j]:
                    indice = j
                    break
            media[1][indice] += int(precos[i])

    flag = True
    for i in range(len(media[0])):
        counter = 0
        for j in range(len(marcas)):
            if media[0][i] == marcas[j]:
                counter += 1
        media[1][i] = int(media[1][i]) / counter
        if flag:
            flag = False
            menor = media[0][i]
            menorv = media[1][i]
        elif media[1][i] < menorv:
            menor = media[0][i]
            menorv = media[1][i]

    print("\nEX001")
    print(f"Marca com valor médio mais baixo: '{menor}'\n")


    #EX002
    ccolunas = ['marca', 'estiloCarroc', 'cavalosPot', 'milhas por galao(cidade)', 'milhas por galao(estrada)']
    clista = []
    for a in range(0, len(ccolunas)):
        arq.seek(0)
        ccoluna = []
        for b in range(2, len(arq.readlines())+1):
            arq.seek(0)
            alinha = arq.readline()
            if (ccolunas[a] not in alinha):
                acounter = -1
            for c in range(len(alinha)):
              if alinha[c:c+len(ccolunas[a])] == ccolunas[a]:
                aindex = c
                break
            acounter = 1
            for d in range(0, aindex):
                if alinha[d] == ';':
                    acounter += 1
            bindex = acounter
            arq.seek(0)
            blinha = b
            for e in range(0, blinha):
                blinha = arq.readline()
            for f in range(bindex-1):
                for g in range(len(blinha)):
                    if blinha[g] == ';':
                        bindice = g
                        break
                blinha = blinha[bindice+1:]
            bstring = ''
            for h in blinha:
                if h == ';' or h == '\n':
                    break
                bstring += h
            ccoluna.append(bstring)
        clista.append(ccoluna[:])

    lista = clista
    carros = [[], [], [], [], []]

    for i in range(len(lista[0])):
        if int(lista[4][i]) - int(lista[3][i]) < 2:
            for j in range(5):
                carros[j].append(lista[j][i])

    print("EX002")
    if len(carros[0]) == 0:
        print("Não há carros com uma diferença de milhas por galão (estrada - cidade) inferior a 2!\n")
    else:
        print("Carros com uma diferença de milhas por galão (estrada - cidade) inferior a 2:\n")
        for i in range(len(carros[0])):
            print(f"Marca: {carros[0][i]} \nEstilo: {carros[1][i]} \nPotência(cavalos): {carros[2][i]}\n")

    #EX003
    ccolunas = ['marca', 'tipoComb']
    clista = []
    for a in range(0, len(ccolunas)):
        arq.seek(0)
        ccoluna = []
        for b in range(2, len(arq.readlines())+1):
            arq.seek(0)
            alinha = arq.readline()
            if (ccolunas[a] not in alinha):
                acounter = -1
            for c in range(len(alinha)):
              if alinha[c:c+len(ccolunas[a])] == ccolunas[a]:
                aindex = c
                break
            acounter = 1
            for d in range(0, aindex):
                if alinha[d] == ';':
                    acounter += 1
            bindex = acounter
            arq.seek(0)
            blinha = b
            for e in range(0, blinha):
                blinha = arq.readline()
            for f in range(bindex-1):
                for g in range(len(blinha)):
                    if blinha[g] == ';':
                        bindice = g
                        break
                blinha = blinha[bindice+1:]
            bstring = ''
            for h in blinha:
                if h == ';' or h == '\n':
                    break
                bstring += h
            ccoluna.append(bstring)
        clista.append(ccoluna[:])

    lista = clista
    combustivel = [[], []]

    for i in range(len(lista[0])):
        if lista[0][i] not in combustivel[0]:
            combustivel[0].append(lista[0][i])
            combustivel[1].append([lista[1][i]])
        else:
            for j in range(len(combustivel[0])):
                if combustivel[0][j] == lista[0][i]:
                    indice = j
            combustivel[1][indice].append(lista[1][i])

    marcas = []
    for i in range(0, len(combustivel[0])):
        gas = diesel = 0
        for j in range(len(combustivel[1][i])):
            if combustivel[1][i][j] == "Gas":
                gas += 1
            else:
                diesel += 1
        if diesel > gas:
            marcas.append(combustivel[0][i])
    
    print("EX003")
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
