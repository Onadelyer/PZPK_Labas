from logging import FileHandler
import random
import re
from datetime import datetime
from datetime import date
from PyQt5.QtWidgets import QMainWindow, QApplication, QFrame, QTableWidgetItem, QVBoxLayout, QTableWidget
from Tasks.MainWindow import Ui_MainWindow
from Tasks.Task1 import Ui_Frame as Ui_Task1
from Tasks.Task2 import Ui_Frame as Ui_Task2
from Tasks.Task3 import Ui_Frame as Ui_Task3
from Tasks.Task4 import Ui_Frame as Ui_Task4
from Tasks.Task5 import Ui_Frame as Ui_Task5
import fileHandler
import json


class Task1(QFrame, Ui_Task1):
    def __init__(self):
        super().__init__()
        
        self.keepersList = []
        self.setupUi(self)
        self.dataTable.setColumnCount(6)
        self.dataTable.setColumnWidth(0, 110)
        self.dataTable.setColumnWidth(1, 110)
        self.dataTable.setColumnWidth(2, 110)
        self.dataTable.setColumnWidth(3, 110)
        self.dataTable.setColumnWidth(4, 110)
        self.dataTable.setColumnWidth(5, 110)
        self.addKeeperButton.clicked.connect(self.addKeeper)
        self.sortButton.clicked.connect(self.sortKeepers)
        
        loaded_keepers = self.getKeepersFromFile("keepers.json")
        if loaded_keepers is not None:
            self.keepersList = loaded_keepers
            self.refreshTable(self.keepersList)
                
    def refreshTable(self, listt):
        rowCount = 0    
        
        self.dataTable.clearContents()
        self.dataTable.setRowCount(0)

    
        for keeper in listt:
            rowCount = self.dataTable.rowCount()
            self.dataTable.insertRow(rowCount)
            for column, value in enumerate(keeper.values()):
                self.dataTable.setItem(rowCount, column, QTableWidgetItem(str(value)))

    def sortKeepers(self):
        current_year = datetime.now().year

        def years_of_employment(employee):
            year_of_employment = int(employee["Year of employment"])
            return current_year - year_of_employment

        keepers = [keeper for keeper in self.keepersList if years_of_employment(keeper) > 10]
        
        self.refreshTable(keepers)

    def addKeeper(self):
        rowCount = self.dataTable.rowCount()
        self.dataTable.insertRow(rowCount)
        
        randomKeeper = self.generateRandomKeeper()
        
        self.keepersList.append(randomKeeper);
        self.writeKeepersToFile(self.keepersList, "keepers.json") 
        self.refreshTable(self.keepersList)

    def writeKeepersToFile(self, keepers, filename):
        with open(filename, 'w') as file:
            json.dump(keepers, file)
        
    def getKeepersFromFile(self, filename):
        try:
            with open(filename, 'r') as file:
                keepers = json.load(file)
            return keepers
        except FileNotFoundError:
            print(f"File '{filename}' not found.")
            return None
        except json.JSONDecodeError:
            print(f"Error decoding JSON from file '{filename}'.")
            return None

    def generateRandomKeeper(self):
        names = ["Max", "John", "Michael", "Robert", "Daniel", "James", "William"]
        surnames = ["Tokar", "Doe", "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis"]
        patronymics = ["Dmytrovych", "Alexandrovich", "Dmitrievich", "Ivanovich", "Nikolaevich", "Sergeyevich", "Vladimirovich"]
        addresses = ["Storogynets", "123 Main St", "456 Elm St", "789 Oak St", "101 Maple Ave", "111 Pine St"]

        random_name = random.choice(names)
        random_surname = random.choice(surnames)
        random_patronymic = random.choice(patronymics)
        random_address = random.choice(addresses)
    
        random_birthday = date(random.randint(1950, 2004), random.randint(1, 12), random.randint(1, 28)).strftime('%d.%m.%Y')
        random_year_of_employment = random.randint(2000, date.today().year + 1)

        keeper = {
            'Name': random_name,
            'Surname': random_surname,
            'Patronymic': random_patronymic,
            'Address': random_address,
            'Birthday': random_birthday,
            'Year of employment': str(random_year_of_employment)
        }

        return keeper
    
class Task2(QFrame, Ui_Task2):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.generateButton.clicked.connect(self.generate)
        self.inputBox.setPlainText(" ".join(fileHandler.read_from_text_file("task2intput.txt")))
        self.outputBox.setPlainText(" ".join(fileHandler.read_from_text_file("task2output.txt")))
        
    def generate(self):
        pattern = re.compile(r'\b\w*a\w*\b')
        inputText = self.inputBox.toPlainText()
        
        matches = pattern.findall(inputText)
        matchesResult = " ".join(matches)
        
        fileHandler.write_to_text_file("task2intput.txt", inputText.split("\n"))
        fileHandler.write_to_text_file("task2output.txt", matchesResult.split("\n"))
        
        self.outputBox.setPlainText(matchesResult)
    
class Task3(QFrame, Ui_Task3):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        
class Task4(QFrame, Ui_Task4):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        
class Task5(QFrame, Ui_Task5):
    def __init__(self):
        super().__init__()
        self.setupUi(self)

class MainWindow(QMainWindow, Ui_MainWindow):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.tab1 = Task1()
        self.tab2 = Task2()
        self.tab3 = Task3()
        self.tab4 = Task4()
        self.tab5 = Task5()

        self.mainFrame.addTab(self.tab1, "Task 1")
        self.mainFrame.addTab(self.tab2, "Task 2")
        self.mainFrame.addTab(self.tab3, "Task 3")
        self.mainFrame.addTab(self.tab4, "Task 4")
        self.mainFrame.addTab(self.tab5, "Task 5")


if __name__ == "__main__":
    import sys
    app = QApplication(sys.argv)
    mainWindow = MainWindow()
    mainWindow.show()
    sys.exit(app.exec_())
