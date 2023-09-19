import Extensions

def Run():

    print("Завдання 2. Дано п’ятизначне число. Визначити суму другої та передостанної його цифр.")


    InputNumberAndGetDigits(Extensions.SafeIntInput("Введіть число"))


    print()
    input()

def InputNumberAndGetDigits(number):
    i = 1
    sum = 0

    while number > 0:
        digit = int(number % 10)
        number = int(number // 10)

        if i == 2 or i == 4:
            sum += digit

        i += 1

    print("Сума другої та передостанньої цифр п'ятизначного числа:", sum)


