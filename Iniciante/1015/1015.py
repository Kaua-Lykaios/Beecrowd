import math

x1, y1 = input().split()
x2, y2 = input().split()
x1 = float(x1)
x2 = float(x2)
y1 = float(y1)
y2 = float(y2)
conta = (x2 - x1)**2 + (y2 -y1)**2

resultado = math.sqrt(conta)
print(f'{resultado:.4f}')