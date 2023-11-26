class Airplane:
    def __init__(self, brand, model, max_speed, max_altitude):
        self.Brand = brand
        self.Model = model
        self.MaxSpeed = max_speed
        self.MaxAltitude = max_altitude

    def cost(self):
        return self.MaxSpeed * 1000 + self.MaxAltitude * 100

    def info(self):
        return f"Airplane: {self.Brand} {self.Model}, \nMax speed: {self.MaxSpeed} km/h, \nMax altitude: {self.MaxAltitude} m, \nCost: {self.cost()}"

class Bomber(Airplane):
    def __init__(self, brand, model, max_speed, max_altitude, pilot_name):
        super().__init__(brand, model, max_speed, max_altitude)
        self.PilotName = pilot_name

    def cost(self):
        return super().cost() * 2

    def info(self):
        return f"Bomber: {self.Brand} {self.Model}, \nMax speed: {self.MaxSpeed} km/h, \nMax altitude: {self.MaxAltitude} m, \nCost: {self.cost()}, \nPilot: {self.PilotName}"

class Fighter(Airplane):
    def __init__(self, brand, model, max_speed, max_altitude, mission_group):
        super().__init__(brand, model, max_speed, max_altitude)
        self.MissionGroup = mission_group

    def cost(self):
        return super().cost() * 3

    def info(self):
        return f"Fighter: {self.Brand} {self.Model}, \nMax speed: {self.MaxSpeed} km/h, \nMax altitude: {self.MaxAltitude} m, \nCost: {self.cost()}, \nMission group: {self.MissionGroup}"
