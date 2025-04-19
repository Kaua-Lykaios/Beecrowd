num = int(input())
alunos_ehd = 0
alunos_epr = 0
alunos_intruso = 0

while num >0 :
    matricula, curso = input().split()
    if curso == 'EHD':
        alunos_ehd += 1
    elif curso == 'EPR':
        alunos_epr += 1
    else:
        alunos_intruso += 1

    