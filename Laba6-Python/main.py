from PyQt5.QtWidgets import QMainWindow, QApplication, QFrame, QTableWidgetItem, QVBoxLayout, QTableWidget
from Tasks.MainWindow import Ui_MainWindow
from Tasks.Task1 import Ui_Frame as Ui_Task1
from Tasks.Task2 import Ui_Frame as Ui_Task2
from Tasks.Task3 import Ui_Frame as Ui_Task3
from Tasks.Task4 import Ui_Frame as Ui_Task4
from Tasks.Task5 import Ui_Frame as Ui_Task5
from Tasks.Task6 import Ui_Frame as Ui_Task6
from Tasks.Task7 import Ui_Frame as Ui_Task7
from TaskModels import customData
from TaskModels import task2Class
from TaskModels import task3Class
from TaskModels import task4Class
from TaskModels import task5Class
from TaskModels import task6Class
from TaskModels import task7Class


class Task1(QFrame, Ui_Task1):
    def __init__(self):
        super().__init__()
        self.data = customData.CustomData()
        self.setupUi(self)
        self.increaseButton.clicked.connect(self.increaseButtonClick)
        self.decreaseButton.clicked.connect(self.decreaseButtonClick)
        self.resultLabel.setText(self.data.__str__())

    def increaseButtonClick(self):
        self.data.increase_year()
        self.resultLabel.setText(self.data.__str__())
    
    def decreaseButtonClick(self):
        self.data.decrease_day_by_2()
        self.resultLabel.setText(self.data.__str__())


class Task2(QFrame, Ui_Task2):
    def __init__(self):
        super().__init__()
        self.bicycle = task2Class.Bicycle()
        self.setupUi(self)
        self.increaseButton.clicked.connect(self.accelerateButtonClick)
        self.stopButton.clicked.connect(self.brakeButtonClick)
        self.resultLabel.setText(self.bicycle.display_info())

    def accelerateButtonClick(self):
        self.bicycle.accelerate(2)
        self.resultLabel.setText(self.bicycle.display_info())

    def brakeButtonClick(self):
        self.bicycle.brake()
        self.resultLabel.setText(self.bicycle.display_info())


class Task3(QFrame, Ui_Task3):
    def __init__(self):
        super().__init__()
        self.task3 = task3Class.Task3Class(30, 9, 2003)
        self.setupUi(self)
        self.calculateButton.clicked.connect(self.calculateButtonClick)
        self.dateLabel.setText("Дата в об'єкті: " + self.task3.__str__())

    def calculateButtonClick(self):
        year = int(self.lineEdit.text())
        self.task3.calculate_age_of_product(year)
        self.yearLabel.setText("Вік продукту: " + str(self.task3.AgeOfProduct))

class Task4(QFrame, Ui_Task4):
    def __init__(self):
        super().__init__()
        self.printedPublication = task4Class.PrintedPublication()
        self.magazine = task4Class.Magazine()
        self.book = task4Class.Book()
        self.textBook = task4Class.Textbook()
        self.setupUi(self)
        self.listOfLabels = [self.label_1, self.label_2, self.label_3, self.label_4]
        self.calculateButton.clicked.connect(self.showButtonClick)
        
    def showButtonClick(self):
        self.listOfLabels[0].setText(self.printedPublication.show())
        self.listOfLabels[1].setText(self.magazine.show())
        self.listOfLabels[2].setText(self.book.show())
        self.listOfLabels[3].setText(self.textBook.show())

class Task5(QFrame, Ui_Task5):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.pushButton.clicked.connect(self.showButtonClick)
        
    def showButtonClick(self):
        if self.typeComboBox.currentText() == "Airplane":
            self.airplane = task5Class.Airplane(self.markinput.text(), self.modelInput.text(), float(self.maxSpeedInput.text()), float(self.maxHeightInput.text()))
            self.label_2.setText(self.airplane.info())
        elif self.typeComboBox.currentText() == "Bomber":
            self.bomber = task5Class.Bomber(self.markinput.text(), self.modelInput.text(), float(self.maxSpeedInput.text()), float(self.maxHeightInput.text()), "Пес патрон")
            self.label_3.setText(self.bomber.info())
        elif self.typeComboBox.currentText() == "Fighter":
            self.fighter = task5Class.Fighter(self.markinput.text(), self.modelInput.text(), float(self.maxSpeedInput.text()), float(self.maxHeightInput.text()), "Тренувальні польоти")
            self.label.setText(self.fighter.info())



class Task6(QFrame, Ui_Task6):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.plantDB = task6Class.PlantDatabase()
        self.generateButton.clicked.connect(self.generateButtonClick)
        self.findButton.clicked.connect(self.findButtonClick)
        
    def generateButtonClick(self):
        self.plantDB.generate_plants()
        self.plantDB.display_information_on_screen(self.resultLabel)

    def findButtonClick(self):
        self.plantDB.display_plants_on_the_verge_of_extinction(self.resultLabel)
    
class Task7(QFrame, Ui_Task7):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.OS = task7Class.CustomOperatingSystem()
        self.app = task7Class.MobileApp()

        self.OS_Result.setText(self.OS.__str__())
        self.Mobile_Result.setText(self.app.__str__())

        self.OSInstallButton.clicked.connect(self.OS.install)
        self.OSUpdateButton.clicked.connect(lambda: self.OS.update(self.OS_Result))
        self.OSWriteCodeButton.clicked.connect(self.OS.write_code)
        self.OSTestCodeButton.clicked.connect(self.OS.test_code)
        self.OSRebootSystemButton.clicked.connect(self.OS.reboot_system)
        self.OSAddUserButton.clicked.connect(self.OS.add_user_to_the_system)
        
        self.MobileInstallButton.clicked.connect(self.app.install)
        self.MobileUpdateButton.clicked.connect(lambda: self.app.update(self.Mobile_Result))
        self.pushButton_9.clicked.connect(self.app.write_code)
        self.MobileTestCodeButton.clicked.connect(self.app.test_code)
        self.MobileTurnOnSecretChinaSpyCameraButton.clicked.connect(self.app.turn_on_secret_china_spy_camera)
        self.MobileEnableRootAccessButton.clicked.connect(self.app.enable_root_access)


class MainWindow(QMainWindow, Ui_MainWindow):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.tab1 = Task1()
        self.tab2 = Task2()
        self.tab3 = Task3()
        self.tab4 = Task4()
        self.tab5 = Task5()
        self.tab6 = Task6()
        self.tab7 = Task7()

        self.MainFrame.addTab(self.tab1, "Task 1")
        self.MainFrame.addTab(self.tab2, "Task 2")
        self.MainFrame.addTab(self.tab3, "Task 3")
        self.MainFrame.addTab(self.tab4, "Task 4")
        self.MainFrame.addTab(self.tab5, "Task 5")
        self.MainFrame.addTab(self.tab6, "Task 6")
        self.MainFrame.addTab(self.tab7, "Task 7")


if __name__ == "__main__":
    import sys
    app = QApplication(sys.argv)
    mainWindow = MainWindow()
    mainWindow.show()
    sys.exit(app.exec_())
