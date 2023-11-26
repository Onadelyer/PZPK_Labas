class Task3Class(CustomData):
    def __init__(self, day, month, year, age_of_product):
        super().__init__(day, month, year)
        self.AgeOfProduct = age_of_product

    def calculate_age_of_product(self, manufacturing_year):
        self.AgeOfProduct = manufacturing_year - self.Year
