import Extensions

def Run():
    print("Завдання 5. Написати програму, яка по даті народження (день d місяць n) визначає знак зодіаку.")

    day = Extensions.SafeIntInput("Введіть день")
    month = Extensions.SafeIntInput("Введіть номер місяця")

    print("Ваш знак зодіаку:", DetermineZodiacSign(day, month))

    print()
    input()

def DetermineZodiacSign(day, month):
    sign = ""

    if month == 1:
        if day <= 19:
            sign = "Козеріг"
        else:
            sign = "Водолій"
    elif month == 2:
        if day <= 18:
            sign = "Водолій"
        else:
            sign = "Риби"
    elif month == 3:
        if day <= 12:
            sign = "Риби"
        else:
            sign = "Овен"
    elif month == 4:
        if day <= 19:
            sign = "Овен"
        else:
            sign = "Телець"
    elif month == 5:
        if day <= 14:
            sign = "Телець"
        else:
            sign = "Близнюки"
    elif month == 6:
        if day <= 21:
            sign = "Близнюки"
        else:
            sign = "Рак"
    elif month == 7:
        if day <= 22:
            sign = "Рак"
        else:
            sign = "Лев"
    elif month == 8:
        if day <= 22:
            sign = "Лев"
        else:
            sign = "Діва"
    elif month == 9:
        if day <= 22:
            sign = "Діва"
        else:
            sign = "Терези"
    elif month == 10:
        if day <= 23:
            sign = "Терези"
        else:
            sign = "Скорпіон"
    elif month == 11:
        if day <= 21:
            sign = "Скорпіон"
        else:
            sign = "Стрілець"
    elif month == 12:
        if day <= 21:
            sign = "Стрілець"
        else:
            sign = "Козеріг"
    else:
        sign = "Невідомий місяць"

    return sign

def InputDate(day, month):
    while True:
        day = Extensions.SafeIntInput("Введіть день: ")

        if day < 1 or day > 31:
            print("День повинен бути від 1 до 31!")
            continue
        else:
            break

    while True:
        month = Extensions.SafeIntInput("Введіть номер місяця: ")

        if month < 1 or month > 12:
            print("Номер місяця повинен бути від 1 до 12!")
            continue
        else:
            break

    return day, month