import ArrayHelper
import ConsoleInput

def Run():
    print("Завдання 7: Для кожного рядка знайти останній парний елемент і записати дані в новий масив.")
    
    n = ConsoleInput.SafeIntInput("Введіть кількість рядків матриці: ")
    
    matrix = ArrayHelper.GenerateStepMatrix(n, -100, 100)
    
    print("Матриця: ")
    ArrayHelper.PrintStepMatrix(matrix)
    
    print("\nМасив: ")
    ArrayHelper.PrintArray(get_last_even_elements(matrix))
    

def get_last_even_elements(matrix):
    result = []
    
    for row in matrix:
        last_even_element = None
        
        for element in row:
            if element % 2 == 0:
                last_even_element = element
        
        if last_even_element is not None:
            result.append(last_even_element)
    
    return result