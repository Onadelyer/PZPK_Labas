from collections import namedtuple

Vehicle = namedtuple('Vehicle', ['name', 'year', 'owner', 'mileage'])

def overhaul(vehicles):
    average_mileage = sum(vehicle.mileage for vehicle in vehicles) / len(vehicles)
    vehicles_to_overhaul = [vehicle.name for vehicle in vehicles if vehicle.mileage >= average_mileage]
    print(f"??????????? ?????? {', '.join(vehicles_to_overhaul)} ? ????? ???? ??????? ?????? ????????? ?????")

# Creating 7 random vehicles
vehicles = [
    Vehicle('Car1', 2010, 'Owner1', 50000),
    Vehicle('Car2', 2012, 'Owner2', 60000),
    Vehicle('Car3', 2015, 'Owner3', 70000),
    Vehicle('Car4', 2018, 'Owner4', 80000),
    Vehicle('Car5', 2019, 'Owner5', 90000),
    Vehicle('Car6', 2020, 'Owner6', 100000),
    Vehicle('Car7', 2021, 'Owner7', 110000)
]

# Calculating average mileage
average_mileage = sum(vehicle.mileage for vehicle in vehicles) / len(vehicles)

# Creating a new list of vehicles with mileage higher than the average
vehicles_above_average = [vehicle._replace(mileage=average_mileage + 1) for vehicle in vehicles]

# Calling the overhaul function with the new list of vehicles
overhaul(vehicles_above_average)
