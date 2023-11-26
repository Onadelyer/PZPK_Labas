from PyQt5.QtWidgets import QApplication, QWidget, QVBoxLayout, QLabel, QPushButton

class PrintedPublication:
    def __init__(self, title="PrintedPublication", author="Невідомий автор", year=2000):
        self.title = title
        self.author = author
        self.year = year

    def get_price(self):
        return 30

    def show(self):
        return f"Назва: {self.title}\nАвтор: {self.author}\nРік видання: {self.year}"


class Magazine(PrintedPublication):
    def __init__(self, title="Magazine", author="Невідомий автор", year=2000, genre="Невідомий жанр"):
        super().__init__(title, author, year)
        self.genre = genre

    def get_price(self):
        return 50

    def show(self):
        return f"{super().show()}\nЖанр: {self.genre}"


class Book(PrintedPublication):
    def __init__(self, title="Book", author="Невідомий автор", year=2000, pageCount=0):
        super().__init__(title, author, year)
        self.page_count = pageCount

    def get_price(self):
        return 20

    def show(self):
        return f"{super().show()}\nКількість сторінок: {self.page_count}"


class Textbook(Book):
    def __init__(self, title="Textbook", author="Невідомий автор", year=2000, pageCount=0, subject="Невідомий предмет"):
        super().__init__(title, author, year, pageCount)
        self.subject = subject

    def get_price(self):
        return 70

    def show(self):
        return f"{super().show()}\nПредмет: {self.subject}"


class MainWindow(QWidget):
    def __init__(self):
        super().__init__()

        self.layout = QVBoxLayout()

        self.label = QLabel(self)
        self.layout.addWidget(self.label)

        self.button = QPushButton('Show Information', self)
        self.button.clicked.connect(self.show_information)
        self.layout.addWidget(self.button)

        self.setLayout(self.layout)

    def show_information(self):
        magazine = Magazine("National Geographic", "Various Authors", 2022, "Science")
        book = Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 180)
        textbook = Textbook("Mathematics for Beginners", "John Doe", 2020, 300, "Mathematics")

        information = f"\nMagazine:\n{magazine.show()}\nPrice: ${magazine.get_price()}\n\n" \
                      f"Book:\n{book.show()}\nPrice: ${book.get_price()}\n\n" \
                      f"Textbook:\n{textbook.show()}\nPrice: ${textbook.get_price()}"

        self.label.setText(information)