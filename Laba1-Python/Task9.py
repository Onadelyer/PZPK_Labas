import math

def Run():
    print("Завдання 9. Написати програму, згідно умови завдання, використовуючи оператор циклу з передумовою(оператор while).")

    print(f"Сума послідовності: {SumTask9()}")

    input()
    print()


def SumTask9():
    sum = 0

    tolerance = 1e-5
    x = 0.1

    n = 1
    while True:
        add_amount = (pow(-1, n - 1) * pow(x, n - 1)) / (pow(2 * n, n) - 1)

        if add_amount < tolerance:
            break

        sum += add_amount
        n += 1

    return round(sum, 3)
