# Найдите
# сумму
# цифр
# трехзначногоc
# числа.

"""
a = int(input())  
c = a % 10 + a // 100 + a // 10 % 10
print(c)
"""

# Петя, Катя и Сережа делают из бумаги журавликов. Вместе
# они сделали S журавликов. Сколько журавликов сделал каждый
# ребенок, если известно, что Петя и Сережа сделали одинаковое
# количество журавликов, а Катя сделала в два раза больше журавликов,
# чем Петя и Сережа вместе?

"""
a = int(input())
c = a // 3
print(c // 2, c * 2, c // 2)
"""

# Вы пользуетесь общественным транспортом? Вероятно, вы
# расплачивались за проезд и получали билет с номером. Счастливым
# билетом называют такой билет с шестизначным номером, где сумма
# первых трех цифр равна сумме последних трех. Т.е. билет с номером
# 385916 – счастливый, т.к. 3+8+5=9+1+6. Вам требуется написать
# программу, которая проверяет счастливость билета.

"""
a = int(input())
c = a % 1000 
d = a // 1000
if c % 10 + c // 100 + c // 10 % 10 == d % 10 + d // 100 + d // 10 % 10:
    print("YES")
else:
    print("NO")
"""

# Требуется определить, можно ли от шоколадки размером n
# × m долек отломить k долек, если разрешается сделать один разлом по
# прямой между дольками (то есть разломить шоколадку на два
# прямоугольника).

"""
a = int(input())
if (a % 10 + a // 100 + a // 10 % 10) % 2 != 0:
    print("YES")
else:
    print("NO")
    """