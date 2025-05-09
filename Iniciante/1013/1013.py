a, b, c = input().split()
a = int(a)
b = int(b)
c = int(c)
valor = [a, b, c ]
maior = valor[0]
for i in valor:
    if i > maior:
        maior = i
print(f'{maior} eh o maior')