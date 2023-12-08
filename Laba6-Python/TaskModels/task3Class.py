from TaskModels.customData import CustomData


class Task3Class(CustomData):
    def __init__(self, day, month, year):
        super().__init__(day, month, year)
        self.AgeOfProduct = 0

    def calculate_age_of_product(self, manufacturing_year):
        self.AgeOfProduct = manufacturing_year - self.Year
        
    def __str__(self):
        return str(self.Day) + "." + str(self.Month) + "." + str(self.Year)
