import math
import Extensions
import Task4

def Run():
    print("Завдання 10. Серія пострілів по мішені. Студент задає із клавіатури координати десяти пострілів. Обчислити чи відбулось попадання в мішень.")

    radius = Extensions.SafeIntInput("Введіть радіус мішені")

    count_of_shoots = 4

    for i in range(count_of_shoots):
        print(f"Постріл №{i + 1}")
        x = Extensions.SafeIntInput("\tX")
        y = Extensions.SafeIntInput("\tY")

        calculate_hit(i + 1, x, y, radius)

def calculate_hit(i, x, y, radius):
    result = Task4.CalculatePointInCircle((x, y), radius)

    print(f"{'Постріл №' + str(i):<10} | ({x:<3}, {y:<3}) | {'Попав' if result else 'Не попав':<7}")

def is_point_in_circle(point, radius):
    return point.X ** 2 + point.Y ** 2 <= radius ** 2