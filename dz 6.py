

# Заполните массив элементами арифметической прогрессии. Её первый элемент, разность и количество
# элементов нужно ввести с клавиатуры. Формула для получения n-го члена прогрессии: a
# n = a1 + (n-1) * d.
# Каждое число вводится с новой строки.
# Ввод: 7 2 5
# Вывод: 7 9 11 13 15'''

"""
def arithmetic_sequence(a, d, n):
    sequence = []
    for i in range(n):
        sequence.append(a + i * d)
    return sequence

result = arithmetic_sequence(7,2,5)
print(result)
"""
# Определить индексы элементов массива (списка),
# значения которых принадлежат заданному диапазону
# (т.е. не меньше заданного минимума и не больше заданного максимума).
# Список можно задавать рандомно

# На входе : [ 1, 5, 88, 100, 2, -4]
# 33
# 200
# Ответ: [2, 3]

"""
def filter_list(list_1, min_value, max_value):
    list_2 = []
    for i in range(len(list_1)):
        if min_value <= list_1[i] <= max_value:
            list_2.append(i)
    return list_2

list_1 = [ 1, 5, 88, 100, 2, -4]
result = filter_list(list_1, 33, 200)
print(result)
"""