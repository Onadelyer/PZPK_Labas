import Extensions


def Run():
    print("Завдання 4. Написати програму, яка визначає, чи попадає точка із заданими координатами (х,у) в заштриховану область на рисунку.")

    point = input_point()

    radius = Extensions.SafeIntInput("Radius: ")

    if CalculatePointInCircle(point, radius):
        print("Точка належить заштрихованій області")
    else:
        print("Точка не належить заштрихованій області")

    print()
    input()
def CalculatePointInCircle(point, radius):
    if point[0] > 0 and point[1] > 0:
        return is_point_in_circle(point, radius)
    elif point[0] < 0 and point[1] < 0:
        return is_point_in_circle(point, radius)
    elif point[0] < 0 and point[1] > 0:
        point1 = (0, 0)
        point2 = (0, radius)
        point3 = (-radius, 0)

        return IsPointInTriangle(point, point1, point2, point3)
    else:
        return False


def sign(p1, p2, p3):
    return (p1[0] - p3[0]) * (p2[1] - p3[1]) - (p2[0] - p3[0]) * (p1[1] - p3[1])

def IsPointInTriangle(point, p1, p2, p3):
    d1, d2, d3 = 0, 0, 0
    has_neg, has_pos = False, False

    d1 = sign(point, p1, p2)
    d2 = sign(point, p2, p3)
    d3 = sign(point, p3, p1)

    has_neg = d1 < 0 or d2 < 0 or d3 < 0
    has_pos = d1 > 0 or d2 > 0 or d3 > 0

    return not (has_neg and has_pos)


def is_point_in_circle(point, radius):
    return point[0] ** 2 + point[1] ** 2 <= radius ** 2

def input_point():
    x = Extensions.SafeIntInput("X")
    y = Extensions.SafeIntInput("Y")

    return (x, y)
