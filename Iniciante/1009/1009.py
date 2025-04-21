vendedor = input()
salario = float(input())
total_vendas = float(input())

comissao = (total_vendas * 0.15) + salario
print(f'TOTAL = R$ {comissao:.2f}')