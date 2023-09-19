import Extensions
import ArrayHelper
import sys

def Run():
    print("Завдання 1. " + "Дано ціле-чисельний масив, що складається із n (позитивних та негативних) елементів.\n" + 
        "Отримати новий масив, як різницю між елементами вхідного масиву та його середнього арифметичного.")

    n = 0
    try:
        n = int(input("Введіть кількість елементів масиву: "))
    except ValueError:
        print("Некоректне значення.")
        sys.exit()

    array = ArrayHelper.GenerateArray(n, 0, 20)

    print("\nПочатковий масив:")
    ArrayHelper.PrintArray(array)

    average = GetAveregeNumberOfArray(array)
    print(f"\nСереднє арифметичне масиву: {average}\n")

    print("Оброблений масив:")
    modifiedArray = GetModifiedArray(array, average)
    ArrayHelper.PrintArray(modifiedArray)

    print()
    input()

def GetModifiedArray(array, average):
    newArray = [0] * len(array)

    for i in range(len(array)):
        newArray[i] = array[i] - average

    return newArray

def GetAveregeNumberOfArray(array):
    sum = 0

    for number in array:
        sum += number

    return sum // len(array)