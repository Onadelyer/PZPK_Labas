class Bicycle:
    def __init__(self, brand="Unknown", year=2022, price=0.0, gear_count=1, is_electric=False, color="Black", current_speed=0.0):
        self.brand = brand
        self.year = year
        self.price = price
        self.gear_count = gear_count
        self.is_electric = is_electric
        self.color = color
        self.current_speed = current_speed

    def accelerate(self, speed_increase):
        self.current_speed += speed_increase
        print(f"Accelerating to {self.current_speed} km/h.")

    def brake(self):
        self.current_speed = 0.0
        print("Bicycle stopped.")

    def display_info(self):
        return (
            f"Brand: {self.brand} "
            f"Year: {self.year} "
            f"Price: ${self.price}\n"
            f"Gears: {self.gear_count} "
            f"Electric: {self.is_electric} "
            f"Color: {self.color}\n"
            f"Current Speed: {self.current_speed} km/h"
        )