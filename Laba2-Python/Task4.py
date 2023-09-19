import random
import ConsoleInput
import ArrayHelper

def Run():
    print("Завдання 4. Розробити програму, яка знаходить і друкує номери тих рядків,")
    print("елементи в яких не повторюються. Якщо таких рядків немає, то друкує повідомлення про це.\n")

    x = 0
    y = 0

    print("Введіть розмірність матриці: ")
    x = safe_int_input("\tX")
    y = safe_int_input("\tY")

    matrix = generate_matrix(y, x)

    print("Матриця")
    print_matrix(matrix)

    calculate_rows_with_no_repeat_numbers(matrix)

def calculate_rows_with_no_repeat_numbers(matrix):
    print()

    for i in range(len(matrix)):
        row = matrix[i]

        if has_repeat_numbers(row):
            print("Рядок #" + str(i+1) + " має повторювані числа")

def has_repeat_numbers(row):
    for i in range(len(row)):
        for j in range(i+1, len(row)):
            if row[i] == row[j]:
                return True

    return False

def generate_matrix(rows, cols):
    matrix = [[random.randint(-50, 49) for _ in range(cols)] for _ in range(rows)]
    return matrix

def print_matrix(matrix):
    for row in matrix:
        for elem in row:
            print(elem, end="\t")
        print()

def safe_int_input(prompt):
    while True:
        try:
            value = int(input(prompt + ": "))
            return value
        except ValueError:
            print("Invalid input. Please enter an integer.")