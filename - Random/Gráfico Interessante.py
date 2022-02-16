import matplotlib.pyplot as plt 
import math


// Retorna a quantidade de fatores de um número x;
def d(x):
    D = []
    for i in range(1,x+1):
        if x % i == 0:
            D.append(i)
    return len(D)


// Retorna a quantidade de números primos até um número x;
def pi(x):
    P = []
    for i in range(1,x+1):
        if d(i) == 2:
            P.append(i)        
    return len(P)


P = []  // Quantidade de números primos até o índice da lista;
X = []  // Números de 1 a 998;
X1 = [] // Valores de 11 a 9999 divididos por 10;
Y = []  // Valores de X1 dividos pelo logaritimo dos valores de X1

for x in range(1,999):
    X.append(x)
    P.append(pi(x))

for x in range(11,10000):
    X1.append(x/10)

for x in X1:
     Y.append(x/math.log(x))

plt.plot(X,P,color="red",label="Função Pi(x)")
plt.plot(X1,Y,color="black",label="estimativa de Gauss")
plt.legend()
plt.title("TEOREMA DO NÚMERO PRIMO")
plt.show()