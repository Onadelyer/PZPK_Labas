from PyQt5 import QtCore, QtGui, QtWidgets
from collections import namedtuple
import random

Vehicle = namedtuple("Vehicle", ["name", "year", "owner", "mileage"])

class Ui_Frame(object):
    def setupUi(self, Frame):
        Frame.setObjectName("Frame")
        Frame.resize(800, 600)
        self.pushButton = QtWidgets.QPushButton(Frame)
        self.pushButton.setGeometry(QtCore.QRect(70, 130, 171, 28))
        self.pushButton.setObjectName("pushButton")
        self.resultLabel = QtWidgets.QLabel(Frame)
        self.resultLabel.setGeometry(QtCore.QRect(300, 10, 491, 581))
        self.resultLabel.setStyleSheet("background-color:rgb(150,150,150)")
        self.resultLabel.setText("")
        self.resultLabel.setAlignment(QtCore.Qt.AlignLeading|QtCore.Qt.AlignLeft|QtCore.Qt.AlignTop)
        self.resultLabel.setObjectName("resultLabel")
        self.repairButton = QtWidgets.QPushButton(Frame)
        self.repairButton.setGeometry(QtCore.QRect(90, 190, 121, 28))
        self.repairButton.setObjectName("repairButton")

        self.retranslateUi(Frame)
        QtCore.QMetaObject.connectSlotsByName(Frame)
        self.pushButton.clicked.connect(self.select_button_click)
        self.repairButton.clicked.connect(self.repair_button_click)
        self.vehicles = create_vehicle_data()
        text = "Vehicles:\n\n"
        for vehicle in self.vehicles:
            text += f"Name: {vehicle.name}, Year: {vehicle.year}, Owner: {vehicle.owner}, Mileage: {vehicle.mileage} km\n"
        self.resultLabel.setText(text)

    def select_button_click(self):
        average = calculate_average_mileage(self.vehicles)
        vehicles_to_repair = identify_vehicles_to_repair(self.vehicles, average)
        text = "Vehicles:\n\n"
        for vehicle in vehicles_to_repair:
            text += f"Name: {vehicle.name}, Year: {vehicle.year}, Owner: {vehicle.owner}, Mileage: {vehicle.mileage} km\n"
        self.resultLabel.setText(text)
        pass
    
    def repair_button_click(self):
        average = calculate_average_mileage(self.vehicles)
        self.vehicles = update_mileage_to_average(self.vehicles, average)
        pass

    def retranslateUi(self, Frame):
        _translate = QtCore.QCoreApplication.translate
        Frame.setWindowTitle(_translate("Frame", "Frame"))
        self.pushButton.setText(_translate("Frame", "Select transport to repair"))
        self.repairButton.setText(_translate("Frame", "Repair transport"))

def create_vehicle_data():
    vehicles = [
        Vehicle("Car", 2020, "John", random.randint(5000, 20000)),
        Vehicle("Truck", 2018, "Alice", random.randint(8000, 25000)),
        Vehicle("Motorcycle", 2019, "Bob", random.randint(2000, 8000)),
        Vehicle("Bus", 2017, "Emily", random.randint(15000, 35000)),
        Vehicle("Scooter", 2021, "Mike", random.randint(1000, 5000)),
        Vehicle("Van", 2016, "Sarah", random.randint(10000, 30000)),
        Vehicle("Bicycle", 2022, "David", random.randint(0, 2000)),
    ]
    return vehicles

def calculate_average_mileage(vehicles):
    total_mileage = sum(vehicle.mileage for vehicle in vehicles)
    average_mileage = total_mileage / len(vehicles)
    return average_mileage

def identify_vehicles_to_repair(vehicles, average_mileage):
    vehicles_to_repair = [vehicle for vehicle in vehicles if vehicle.mileage >= average_mileage]
    return vehicles_to_repair

def update_mileage_to_average(vehicles, average_mileage):
    vehicles_to_repair = identify_vehicles_to_repair(vehicles, average_mileage)
    return [vehicle._replace(mileage=average_mileage) for vehicle in vehicles_to_repair]
