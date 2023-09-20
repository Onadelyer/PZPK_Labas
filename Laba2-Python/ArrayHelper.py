import random

def GenerateArray(countOfElements, elementMin = -100, elementMax = 100):
    array = []

    for i in range(countOfElements):
        array.append(random.randint(elementMin, elementMax))

    return array

def InputArray(countOfElements):
    array = []

    for i in range(countOfElements):
        array.append(int(input(f"Element №{i + 1}: ")))

    return array

def InputMatrix(countOfColumns, countOfRows):
    matrix = []

    for i in range(countOfColumns):
        row = []
        for j in range(countOfRows):
            row.append(int(input(f"Element [{i + 1}][{j + 1}]: ")))
        matrix.append(row)

    return matrix

def GenerateMatrix(countOfColumns, countOfRows, elementMin = -100, elementMax = 100):
    matrix = []

    for i in range(countOfColumns):
        row = []
        for j in range(countOfRows):
            row.append(random.randint(elementMin, elementMax))
        matrix.append(row)

    return matrix

def GenerateStepMatrix(countOfRows, elementMin = -100, elementMax = 100):
    matrix = []

    for i in range(countOfRows):
        row = []
        for j in range(i + 1):
            row.append(random.randint(elementMin, elementMax))
        matrix.append(row)

    return matrix


def PrintArray(array):
    for i in range(len(array)):
        print("{0:5}".format(array[i]), end='')
    print()

def PrintMatrix(matrix):
    for i in range(len(matrix)):
        for j in range(len(matrix[i])):
            print("{0:5}".format(matrix[i][j]), end='')
        print()
        print()
        
def PrintStepMatrix(matrix):
    for i in range(len(matrix)):
        for j in range(len(matrix[i])):
            print("{0:5}".format(matrix[i][j]), end='')
        print()