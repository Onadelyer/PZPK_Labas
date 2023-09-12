import Extensions
import math

def Run():
    print("Завдання 7. Написати програму, згідно умови завдання, використовуючи оператор циклу з параметром (оператор for).")

    k = Extensions.SafeIntInput("Введіть k")
    x = Extensions.SafeIntInput("Введіть x")

    print(f"Сума послідовності: {SumTask7(k, x)}")

    input()
    print()


def SumTask7(k, x):
    sum = 0

    for n in range(1, int(k)):
        sum += pow(-1, n) * ((n + 1) / (pow(n * x, 2) + 1))

    return round(sum, 3)
