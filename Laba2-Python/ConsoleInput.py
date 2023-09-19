def safe_int_input(message):
    while True:
        try:
            value = int(input(message + ": "))
            return value
        except ValueError:
            print("Введіть ціле число!")

def safe_double_input(message):
    while True:
        try:
            value = float(input(message + ": "))
            return value
        except ValueError:
            print("Введіть ціле число!")