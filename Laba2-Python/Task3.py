import ConsoleInput
import ArrayHelper
import math

def Run():
    print("Завдання 3. Обчислити елементи масиву Y за формулою. Сформувати та вивести на екран новий масив R, \n" +
            "елементами якого є парні за індексом елементи вихідного (початкового) масиву Х та масиву Y.\n")

    n = int(input("Введіть кількість елементів масиву: "))

    array = generate_array(n)

    print("Массив X:")
    print_array(array)

    print("\nМассив Y:")
    print_array(get_array_y(array))

def generate_array(n):
    array = [i+1 for i in range(n)]
    return array

def print_array(array):
    for i in array:
        print(i)

def get_array_y(array_x):
    array_y = []

    for x in array_x:
        if math.cos(x) > 0:
            array_y.append(math.pow(x, 3) - 7.5)
        elif math.sin(x) <= 0:
            array_y.append(math.pow(x, 2) - (5 * math.pow(math.e, math.sin(x))))

    return array_y

run_task3()