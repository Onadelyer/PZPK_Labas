def SafeIntInput(message):
    while True:
        try:
            return float(input(f"{message}: "))
        except ValueError:
            print("Введіть ціле число!")