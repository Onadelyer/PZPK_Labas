import math
import Extensions


def Run():
    for i in range(3):
        GetFunctionValue()

def GetFunctionValue():
    x = Extensions.SafeIntInput("Введіть значення аргументу: ")

    if x < -4 or x > 10:
        print("Значення функції немає")
    elif -4 <= x <= -2:
        print(f"Значення функції: {x + 3}")
    elif -2 <= x <= 4:
        print(f"Значення функції: {-x / 2}")
    elif 4 <= x <= 6:
        print("Значення функції: -2")
    elif 6 <= x <= 10:
        result = -2 + math.sqrt(4 - (x - 8) ** 2)
        print(f"Значення функції: {round(result, 3)}")
