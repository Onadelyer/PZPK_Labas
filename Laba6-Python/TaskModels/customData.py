class CustomData:
    def __init__(self, day=1, month=1, year=1):
        self.Day = day
        self.Month = month
        self.Year = year

    def increase_year(self):
        self.Year += 1

    def decrease_day_by_2(self):
        if self.Day > 2:
            self.Day -= 2
        else:
            if self.Month > 1:
                self.Month -= 1
                self.Day = 30
            else:
                if self.Year > 0:
                    self.Year -= 1
                    self.Month = 12
                    self.Day = 30

    def __str__(self):
        return f"Day: {self.Day}, Month: {self.Month}, Year: {self.Year}"

    def __del__(self):
        print("Object deleted from memory")