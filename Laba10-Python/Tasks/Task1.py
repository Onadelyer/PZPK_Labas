from collections import deque
import PyQt5
from PyQt5.QtWidgets import QWidget, QLabel, QPushButton, QVBoxLayout, QHBoxLayout, QFileDialog, QMessageBox
from PyQt5.QtCore import QFile, QTextStream

class Task1(QWidget):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Task1")
        self.setGeometry(100, 100, 800, 450)

        layout = QVBoxLayout(self)

        self.resultLabel = QLabel("Result", self)
        layout.addWidget(self.resultLabel)

        loadButton = QPushButton("Load file", self)
        verifyButton = QPushButton("Verify", self)

        buttonLayout = QHBoxLayout()
        buttonLayout.addWidget(loadButton)
        buttonLayout.addWidget(verifyButton)

        layout.addLayout(buttonLayout)

        loadButton.clicked.connect(self.Button_Click)
        verifyButton.clicked.connect(self.Button_Click2)

    def Button_Click(self):
        file_dialog = QFileDialog()
        file_name = file_dialog.getOpenFileName()
        if file_name[0]:
            file = QFile(file_name[0])
            if file.open(QFile.ReadOnly | QFile.Text):
                text_stream = QTextStream(file)
                self.loaded_text = text_stream.readAll()
                self.resultLabel.setText(self.loaded_text)
        pass

    def Button_Click2(self):
        input_text = self.loaded_text
        is_valid = self.validate_brackets(input_text)

        msg = QMessageBox()
        if is_valid:
            msg.setText("Input is correct")
        else:
            msg.setText("Input is incorrect")
        msg.exec_()

    def validate_brackets(self, text):
        if not text:
            return False

        stack = deque()

        for c in text:
            if c == '(':
                stack.append(c)
            elif c == ')':
                if not stack or stack[-1] != '(':
                    return False
                stack.pop()

        return len(stack) == 0
