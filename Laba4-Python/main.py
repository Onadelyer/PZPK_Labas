from asyncio.windows_events import NULL
import re
from PyQt5.QtWidgets import QMainWindow, QApplication, QFrame, QVBoxLayout
from Tasks.MainWindow import Ui_MainWindow
from Tasks.Task1 import Ui_Frame as Ui_Task1
from Tasks.Task2 import Ui_Frame as Ui_Task2
from Tasks.Task3 import Ui_Frame as Ui_Task3
from Tasks.Task4 import Ui_Frame as Ui_Task4


class Task1(QFrame, Ui_Task1):

    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.inputBox.textChanged.connect(self.replaceText)

    def replaceText(self):
        pattern = re.compile(r'[0-9]')
        self.outputBox.setText(re.sub(pattern, "!", self.inputBox.text()))

class Task2(QFrame, Ui_Task2):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.inputBox.textChanged.connect(self.replaceText)

    def replaceText(self):
        pattern = re.compile(r'\b(10|[0-9]|[A-F])\.(10|[0-9]|[A-F])\.(10|[0-9]|[A-F])\.(10|[0-9]|[A-F])\b')
        matches = re.finditer(pattern, self.inputBox.text())
        result = " ".join(match.group() for match in re.finditer(pattern, self.inputBox.text()))
        matches_count = sum(1 for _ in matches)
        replaced_output_text = re.sub(pattern, self.replaceCharacterBox.text(), self.inputBox.text())

        self.replacedResultBox.setText(replaced_output_text)
        self.outputBox.setText(result)
        
class Task3(QFrame, Ui_Task3):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.inputBox.textChanged.connect(self.replaceText)
        
    def replaceText(self):
        pattern = re.compile(r'\b[A-Za-z]+\b')
        self.outputBox.setText(re.sub(pattern, "...", self.inputBox.text()))
        
class Task4(QFrame, Ui_Task4):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.inputBox.textChanged.connect(self.replaceText)
        
    def replaceText(self):
        self.outputBox.setText(self.find_longest_word_chain(self.inputBox.text()))

    def find_longest_word_chain(self, text):
        words = re.findall(r'\b\w+\b', text)  # Extract words from the text

        current_chain = []
        longest_chain = []

        for word in words:
            if not current_chain or len(word) == len(current_chain[-1]):
                current_chain.append(word)
            else:
                current_chain = [word]

            if len(current_chain) > len(longest_chain):
                longest_chain = current_chain

        return " ".join(longest_chain)

class MainWindow(QMainWindow, Ui_MainWindow):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.tab1 = Task1()
        self.tab2 = Task2()
        self.tab3 = Task3()
        self.tab4 = Task4()

        self.tabWidget.addTab(self.tab1, "Task 1")
        self.tabWidget.addTab(self.tab2, "Task 2")
        self.tabWidget.addTab(self.tab3, "Task 3")
        self.tabWidget.addTab(self.tab4, "Task 4")


if __name__ == "__main__":
    import sys
    app = QApplication(sys.argv)
    mainWindow = MainWindow()
    mainWindow.show()
    sys.exit(app.exec_())
