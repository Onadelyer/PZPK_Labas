import extensions
import numpy as np

def run():
    print("Завдання 6. У двовимірному масиві зберігається дохід 10 магазинів за кожен місяць року (кожному магазину відповідає один рядок). " +
        "\nНаписати програму, що визначає дохід обраного користувачем магазину за обраний квартал року.")

    matrix = np.random.randint(0, 1000, (10, 12))

    print("\nМатриця:\n")
    print_profit_matrix(matrix)

    ask_client_for_profit(matrix)

def print_profit_matrix(matrix):
    months = ["Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень",
              "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень"]

    print(f"\n{'МІСЯЦІ': <13}", end="")
    for month in months:
        print(f"{month: >10}", end="")
    print()

    for i in range(matrix.shape[0]):
        print(f"Магазин #{i+1}: ", end="")
        for j in range(matrix.shape[1]):
            print(f"{matrix[i, j]: >10}", end="")
        print()

def ask_client_for_profit(matrix):
    print()

    is_asking = True

    while is_asking:
        shop_index = int(input("Введіть номер магазину: "))
        month_index = int(input("Введіть номер місяця: "))

        print(f"Дохід магазину #{shop_index} за місяць #{month_index}: {matrix[shop_index - 1, month_index - 1]}")

        answer = input("Продовжити? (y/n)")
        is_asking = answer.lower() == 'y'