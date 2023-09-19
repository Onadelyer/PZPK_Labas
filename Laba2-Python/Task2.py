from Extensions import ConsoleInput
import sys

def run():
    print("Завдання 2. Задано масив. Знайти суму чисел, що знаходяться між максимальним і мінімальним елементами масиву")
    print("(в суму включити ці елементи). Вивести суму на екран.")

    n = ConsoleInput.SafeIntInput("Введіть кількість елементів масиву")
    array = generate_array(n)

    print("Масив: ")
    print_array(array)

    get_sum_between_max_and_min(array)

def generate_array(n):
    array = []
    for i in range(n):
        array.append(i+1)
    return array

def print_array(array):
    for i in range(len(array)):
        print(f"Елемент {i+1}: {array[i]}")

def get_sum_between_max_and_min(array):
    maxIndex = array[0]
    minIndex = array[0]
    sum = 0

    for i in range(len(array)):
        if array[i] > array[i+1]:
            maxIndex = i

    for i in range(len(array)):
        if array[i] > array[i + 1]:
             maxIndex = i

    firstIndex = min(maxIndex, minIndex)
    secondIndex = max(maxIndex, minIndex)

    for i in range(firstIndex, secondIndex+1):
        sum+= array[i]

    print("Cума між мінімальним і максимальним елементом:", sum)

if __name__ == "__main__":
    run()