import ConsoleInput
import ArrayHelper
import sys

def Run():
    print("Завдання 2. Задано масив. Знайти суму чисел, що знаходяться між максимальним і мінімальним елементами масиву")
    print("(в суму включити ці елементи). Вивести суму на екран.")

    n = ConsoleInput.SafeIntInput("Введіть кількість елементів масиву")
    array = ArrayHelper.GenerateArray(n)

    print("Масив: ")
    ArrayHelper.PrintArray(array)

    get_sum_between_max_and_min(array)

def print_array(array):
    for i in range(len(array)):
        print(f"Елемент {i+1}: {array[i]}")

def get_sum_between_max_and_min(array):
    maxIndex = array.index(max(array))
    minIndex = array.index(min(array))
    sum = 0    

    firstIndex = min(maxIndex, minIndex)
    secondIndex = max(maxIndex, minIndex)

    for i in range(firstIndex, secondIndex+1):
        sum+= array[i]

    print("Cума між мінімальним і максимальним елементом:", sum)