from tkinter import Button
from PyQt5.QtWidgets import QMainWindow, QApplication, QFrame, QVBoxLayout
from Tasks.MainWindow import Ui_MainWindow
from Tasks.Task1 import Ui_Frame as Ui_Task1
from Tasks.Task2 import Ui_Frame as Ui_Task2
from Tasks.Task3 import Ui_Frame as Ui_Task3
from Tasks.Task4 import Ui_Frame as Ui_Task4
from Tasks.Task5 import Ui_Frame as Ui_Task5


class Task1(QFrame, Ui_Task1):

    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.addKeeperButton.clicked.connect(self.addKeeper)
        
    def addKeeper(self):
        
    
class Task2(QFrame, Ui_Task2):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        
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
