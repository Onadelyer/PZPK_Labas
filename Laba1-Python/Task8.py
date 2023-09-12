import math

def Run():
    print("Завдання 8. Написати програму, згідно умови завдання з використанням вкладених інструкцій оператора for.")

    print(f"Сума послідовності: {SumTask8()}")

    input()
    print()


def SumTask8():
    sum = 0

    for x in range(1, 6):
        for k in range(0, int(1e9)):
            add_amount = (pow(-1, k) * pow(x, k + 2)) / ((k + 1) * Factorial(k + 2))

            if add_amount < 1e-9:
                break

            sum += add_amount

    return round(sum, 3)


def Factorial(x):
    if x == 0:
        return 1
    else:
        return x * Factorial(x - 1)
