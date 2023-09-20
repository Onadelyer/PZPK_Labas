def SafeIntInput(message):
    while True:
        try:
            value = int(input(message + ": "))
            return value
        except ValueError:
            print("Введіть ціле число!")

def SafeFloatInput(message):
    while True:
        try:
            value = float(input(message + ": "))
            return value
        except ValueError:
            print("Введіть ціле число!")