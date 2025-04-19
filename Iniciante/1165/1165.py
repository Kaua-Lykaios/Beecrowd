def primo(x):
    qtd_divisores = 0

    pd = 1
    while  pd <= x:
        if x % pd == 0:
            qtd_divisores += 1
        pd += 1
    if qtd_divisores == 2:
        return True
    else:
        return False
n = int(input())
while n > 0:
    x = int(input())
    if primo(x):
        print(f'{x} e primo' )
    else:
        print(f'{x} não é primo')
    n-=1