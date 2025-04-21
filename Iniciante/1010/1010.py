codigo, quantidade, valor = input().split()
codigo = int(codigo)
quantidade = int(quantidade)
valor = float(valor)

codigo2, quantidade2, valor2 = input().split()
codigo2 = int(codigo2)
quantidade2 = int(quantidade2)
valor2 = float(valor2)

resultado = (quantidade * valor) + (quantidade2 * valor2)
print(f'VALOR A PAGAR: R$ {resultado:.2f}')

