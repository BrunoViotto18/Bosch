import os

while True:
    print('COMBOS:')
    print('[ 1 ] X-Salada + Fritas + KS(sabores)')
    print('[ 2 ] X-Picanha Bacon + Fritas + KS(sabores)')
    print('[ 3 ] X-Calbresa Vinagrete + Nuggets + KS(sabores)')
    print('[ 4 ] X-Frango Salada + Anéis de Cebola + KS(sabores)')
    print('[ 5 ] Duplo Cheddar Bacon + Fritas + KS(sabores)')
    print('[ 6 ] X-Burguer + Batata Sorriso + Coca 200ml ou Suco(consulte) + Danoninho')
    print('[ 7 ] Sair')
    combo = int(input('Escolha um combo: '))

    os.system('cls')
    if combo == 1:
        print('Combo 1: X-Salada + Fritas + KS(sabores)\n')
        print('Preço: R$23,99')

    elif combo == 2:
        print('Combo 2: X-Picanha Bacon + Fritas + KS(sabores)\n')
        print('Preço: R$27,99')

    elif combo == 3:
        print('Combo 3: X-Calbresa Vinagrete + Nuggets + KS(sabores)\n')
        print('Preço: R$26,99')
        
    elif combo == 4:
        print('Combo 4: X-Frango Salada + Anéis de Cebola + KS(sabores)\n')
        print('Preço: R$25,99')
        
    elif combo == 5:
        print('Combo 5: Duplo Cheddar Bacon + Fritas + KS(sabores)\n')
        print('Preço: R$32,99')
        
    elif combo == 6:
        print('Combo 6: X-Burguer + Batata Sorriso + Coca 200ml ou Suco(consulte) + Danoninho\n')
        print('Preço: R$16,99')

    elif combo == 7:
        break

    else:
        print('Valor inválido! Tente novamente.\n')

    os.system('pause')
