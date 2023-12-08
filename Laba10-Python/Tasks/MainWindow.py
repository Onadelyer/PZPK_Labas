import sys
from PyQt5.QtWidgets import QApplication, QMainWindow, QWidget, QVBoxLayout, QPushButton, QLabel, QFrame, QHBoxLayout

class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("MainWindow")
        self.setGeometry(100, 100, 800, 450)

        self.centralWidget = QWidget()
        self.setCentralWidget(self.centralWidget)

        self.layout = QVBoxLayout(self.centralWidget)

        self.mainFrame = QFrame()
        self.layout.addWidget(self.mainFrame)

        self.stackPanel = QHBoxLayout()
        self.layout.addLayout(self.stackPanel)

        self.task1Button = QPushButton("Task1")
        self.stackPanel.addWidget(self.task1Button)

        self.task2Button = QPushButton("Task2")
        self.stackPanel.addWidget(self.task2Button)

        self.task3Button = QPushButton("Task3")
        self.stackPanel.addWidget(self.task3Button)

        self.task4Button = QPushButton("Task4")
        self.stackPanel.addWidget(self.task4Button)

        self.task1Button.clicked.connect(self.Task1Click)
        self.task2Button.clicked.connect(self.Task2Click)
        self.task3Button.clicked.connect(self.Task3Click)
        self.task4Button.clicked.connect(self.Task4Click)

    def Task1Click(self):
        # Handle Task1 button click here
        pass

    def Task2Click(self):
        # Handle Task2 button click here
        pass

    def Task3Click(self):
        # Handle Task3 button click here
        pass

    def Task4Click(self):
        # Handle Task4 button click here
        pass

if __name__ == "__main__":
    app = QApplication(sys.argv)
    mainWindow = MainWindow()
    mainWindow.show()
    sys.exit(app.exec_())
