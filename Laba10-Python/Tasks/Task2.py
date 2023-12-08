from PyQt5.QtWidgets import QWidget, QPushButton, QVBoxLayout, QListWidget, QMessageBox
import random

class Task2(QWidget):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Task2")
        self.setGeometry(100, 100, 800, 450)

        layout = QVBoxLayout(self)

        pushFrontButton = QPushButton("Push Front", self)
        pushBackButton = QPushButton("Push Back", self)
        popFrontButton = QPushButton("Pop Front", self)
        popBackButton = QPushButton("Pop Back", self)
        frontButton = QPushButton("Front", self)
        backButton = QPushButton("Back", self)
        sizeButton = QPushButton("Size", self)
        clearButton = QPushButton("Clear", self)

        self.dequeListBox = QListWidget(self)

        layout.addWidget(pushFrontButton)
        layout.addWidget(pushBackButton)
        layout.addWidget(popFrontButton)
        layout.addWidget(popBackButton)
        layout.addWidget(frontButton)
        layout.addWidget(backButton)
        layout.addWidget(sizeButton)
        layout.addWidget(clearButton)
        layout.addWidget(self.dequeListBox)

        self.deque = [] 

        pushFrontButton.clicked.connect(self.PushFront_Click)
        pushBackButton.clicked.connect(self.PushBack_Click)
        popFrontButton.clicked.connect(self.PopFront_Click)
        popBackButton.clicked.connect(self.PopBack_Click)
        frontButton.clicked.connect(self.Front_Click)
        backButton.clicked.connect(self.Back_Click)
        sizeButton.clicked.connect(self.Size_Click)
        clearButton.clicked.connect(self.Clear_Click)

    def PushFront_Click(self):
        value = self.GetRandomValue()
        self.deque.insert(0, value)
        self.UpdateDequeListBox()

    def PushBack_Click(self):
        value = self.GetRandomValue()
        self.deque.append(value)
        self.UpdateDequeListBox()

    def PopFront_Click(self):
        if self.deque:
            self.deque.pop(0)
            self.UpdateDequeListBox()
        else:
            QMessageBox.warning(self, 'Deque Empty', 'Deque is empty')

    def PopBack_Click(self):
        if self.deque:
            self.deque.pop()
            self.UpdateDequeListBox()
        else:
            QMessageBox.warning(self, 'Deque Empty', 'Deque is empty')

    def Front_Click(self):
        if self.deque:
            QMessageBox.information(self, 'Front Value', f'Front value: {self.deque[0]}')
        else:
            QMessageBox.warning(self, 'Deque Empty', 'Deque is empty')

    def Back_Click(self):
        if self.deque:
            QMessageBox.information(self, 'Back Value', f'Back value: {self.deque[-1]}')
        else:
            QMessageBox.warning(self, 'Deque Empty', 'Deque is empty')

    def Size_Click(self):
        QMessageBox.information(self, 'Deque Size', f'Deque size: {len(self.deque)}')

    def Clear_Click(self):
        self.deque.clear()
        self.UpdateDequeListBox()

    def GetRandomValue(self):
        return random.randint(1, 100)

    def UpdateDequeListBox(self):
        self.dequeListBox.clear()
        self.dequeListBox.addItems(map(str, self.deque))
