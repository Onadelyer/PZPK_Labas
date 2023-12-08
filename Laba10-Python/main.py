
from asyncio import tasks
import sys
from PyQt5.QtWidgets import QApplication, QMainWindow, QStackedWidget
    
from Tasks.MainWindow import MainWindow
from Tasks.Task1 import Task1
from Tasks.Task2 import Task2
from Tasks.Task3 import Task3
from Tasks.Task4 import Task4

class MainApplication(QMainWindow):
    def __init__(self):
        super().__init__()

        self.setWindowTitle("Main Application")
        self.setGeometry(100, 100, 800, 450)

        self.centralWidget = QStackedWidget()
        self.setCentralWidget(self.centralWidget)

        self.mainWindow = MainWindow()
        self.task1 = Task1()
        self.task2 = Task2()
        self.task3 = Task3()
        self.task4 = Task4()

        # Add all task pages to the stacked widget
        self.centralWidget.addWidget(self.mainWindow)
        self.centralWidget.addWidget(self.task1)
        self.centralWidget.addWidget(self.task2)
        self.centralWidget.addWidget(self.task3)
        self.centralWidget.addWidget(self.task4)

        self.mainWindow.task1Button.clicked.connect(self.show_task1)
        self.mainWindow.task2Button.clicked.connect(self.show_task2)
        self.mainWindow.task3Button.clicked.connect(self.show_task3)
        self.mainWindow.task4Button.clicked.connect(self.show_task4)

    def show_task1(self):
        self.centralWidget.setCurrentWidget(self.task1)

    def show_task2(self):
        self.centralWidget.setCurrentWidget(self.task2)

    def show_task3(self):
        self.centralWidget.setCurrentWidget(self.task3)

    def show_task4(self):
        self.centralWidget.setCurrentWidget(self.task4)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    mainApp = MainApplication()
    mainApp.show()
    sys.exit(app.exec_())
