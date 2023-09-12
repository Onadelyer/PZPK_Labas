import Extensions

def Run():
    print("Завдання 1. Обчислити площу та периметр рівнобічної трапеції, для якої задано довжини основ та висоту.")

    trapeze = InputTrapeze()

    area = (trapeze[0] + trapeze[1]) * trapeze[2] / 2
    perimeter = trapeze[0] + trapeze[1] + trapeze[0] + trapeze[1]

    print("Площа трапеції: ", area)
    print("Периметр трапеції: ", perimeter)

    print()
    input()

def InputTrapeze():
    trapezoidBase1 = Extensions.SafeIntInput("Введіть довжину першої основи")
    trapezoidBase2 = Extensions.SafeIntInput("Введіть довжину другої основи")

    height = Extensions.SafeIntInput("Введіть висоту")

    return trapezoidBase1, trapezoidBase2, height


