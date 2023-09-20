import random
import ConsoleInput
import ArrayHelper

def Run():
    print("Завдання 5. У заданій матриці розмірності 6 на 4 визначити номер стовпця з мінімальною " +
          "сумою елементів і величину цієї суми.")

    matrix = ArrayHelper.GenerateMatrix(6, 4, -50, 49)

    print("Матриця:")
    ArrayHelper.PrintMatrix(matrix)

    calculate_column_with_min_sum(matrix)

def generate_matrix(rows, cols, min_value, max_value):
    matrix = []
    for _ in range(rows):
        row = [random.randint(min_value, max_value) for _ in range(cols)]
        matrix.append(row)
    return matrix

def print_matrix(matrix):
    for row in matrix:
        print(row)

def calculate_column_with_min_sum(matrix):
    min_sum = float('inf')
    min_sum_column_index = -1
    for j in range(len(matrix[0])):
        sum = 0
        for i in range(len(matrix)):
            sum += matrix[i][j]
        if sum < min_sum:
            min_sum = sum
            min_sum_column_index = j
    print("Номер стовпця з мінімальною сумою елементів:", min_sum_column_index + 1)
    print("Величина цієї суми:", min_sum)
