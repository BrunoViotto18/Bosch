import random
dinheiro = 500
aposta = 0
cartasjogador = []
cartaspc = []
s = 0
spc = 0
lucro = 0

def hit():
    global cartasjogador
    global s
    global cartaspc
    global spc
    dic = {'A': 1,'2':2,'3':3,'4':4,'5':5,'6':6,'7':7,'8':8,'9':9,'10':10,'Q':10,'J': 10, 'K': 10}
    cartahit, id = random.choice(list(dic.items()))
    cartasjogador.append(cartahit)
    s = s + dic[cartahit]
    if spc < 17:
        cartapchit, id = random.choice(list(dic.items()))
        cartaspc.append(cartapchit)
        spc = spc + dic[cartapchit]
    print(cartahit)
    print('Pontos: ',s)
    
def cartas():
    global cartasjogador
    global s
    global spc
    dic = {'A': 1,'2':2,'3':3,'4':4,'5':5,'6':6,'7':7,'8':8,'9':9,'10':10,'Q':10,'J': 10, 'K': 10}
    carta, id = random.choice(list(dic.items()))
    carta2, id = random.choice(list(dic.items()))
    cartapc, id = random.choice(list(dic.items()))
    cartapc2, id = random.choice(list(dic.items()))
    cartasjogador.append(carta)
    cartasjogador.append(carta2)
    cartaspc.append(cartapc)
    cartaspc.append(cartapc2)
    
    s = dic[carta]+dic[carta2]
    spc = dic[cartapc]+dic[cartapc2]
    print(carta,carta2)
    print('Pontos: ',s)

def jogo():
    global spc
    print('\n')
    print('Seu saldo:', dinheiro)
    aposta = int(input('Quanto deseja apostar?: '))
    if aposta > dinheiro:
            print('Você não pode apostar esse valor!')
    else:
            print('Suas cartas são: ')
            cartas()
            resposta = input('Deseja dar outro HIT?\n (S)sim\n (N)não\n Resposta: ')
            while resposta == 'S':
                resposta = input('Deseja dar outro HIT?\n (S)sim\n (N)não\n Resposta: ')
                if resposta == "N":
                    break
                else:
                    hit()
                
            if resposta == 'N':
                print ('Cartas do computador: ', cartaspc)
                print ('Suas cartas: ', cartasjogador)
                print ('Pontuação do computador: ', spc)
                print ('Sua pontuação: ', s)
                if spc > s or s > 21:
                    print('\n')
                    print('Você perdeu! Valor perdido!', aposta)
                else: 
                    lucro = dinheiro + aposta
                    print('\f Parabens! Valor ganho: ', lucro)
                    
                
                
print ('=============BLACKJACK=============')
entrar = input('OLA, DESEJA DAR UM HIT?\n (S)sim\n (N)não\n Resposta: ')

if entrar == 'S':
    jogo()
else:
    print('BLZ, FLW')
    
