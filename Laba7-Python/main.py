from collections import namedtuple
from PyQt5.QtWidgets import QMainWindow, QApplication, QFrame, QMessageBox, QTableWidgetItem, QVBoxLayout, QTableWidget
from Tasks.MainWindow import Ui_MainWindow
from statistics import mean
from Tasks.Task1 import Ui_Frame as Ui_Task1
from Tasks.Task2 import Ui_Frame as Ui_Task2
from Tasks.Task3 import Ui_Frame as Ui_Task3
from TaskModels.task1Class import KindOfSport, AgeSection

GameResult = namedtuple('GameResult', ['team_name', 'total_score', 'sport_kind', 'age_group'])

class Task1(QFrame, Ui_Task1):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.game_results = []
        self.generate_game_results()
        self.showButton.clicked.connect(self.show_button_click)
        self.pushButton_2.clicked.connect(self.select_button_click)
    
    def show_button_click(self):
        self.resultLabel.setText("")

        for result in self.game_results:
            self.resultLabel.setText(f"{self.resultLabel.text()}Назва:{result.team_name}    Загальний бал:{result.total_score}    Вид спорту:{result.sport_kind.name}    Вікова група:{result.age_group.name}\n")

    def select_button_click(self):
        self.resultLabel.setText("")

        average_score = sum(result.total_score for result in self.game_results) / len(self.game_results)
        selected_results = [result for result in self.game_results if result.total_score > average_score]

        for result in selected_results:
            self.resultLabel.setText(f"{self.resultLabel.text()}Назва:{result.team_name}    Загальний бал:{result.total_score}    Вид спорту:{result.sport_kind.name}    Вікова група:{result.age_group.name}\n")

        self.label.setText("Count of passed teams: " + str(len(selected_results)))

    def generate_game_results(self):
        self.game_results.append(GameResult("Team1", 1, KindOfSport.Volleyball, AgeSection.Junior))
        self.game_results.append(GameResult("Team2", 2, KindOfSport.Basketball, AgeSection.Senior))
        self.game_results.append(GameResult("Team3", 3, KindOfSport.Tennis, AgeSection.Middle))
        self.game_results.append(GameResult("Team4", 4, KindOfSport.Basketball, AgeSection.Junior))
        self.game_results.append(GameResult("Team5", 5, KindOfSport.Hockey, AgeSection.Senior))
        self.game_results.append(GameResult("Team6", 6, KindOfSport.Volleyball, AgeSection.Middle))
        self.game_results.append(GameResult("Team7", 7, KindOfSport.Football, AgeSection.Junior))
        self.game_results.append(GameResult("Team8", 8, KindOfSport.Tennis, AgeSection.Senior))
        self.game_results.append(GameResult("Team9", 9, KindOfSport.Football, AgeSection.Middle))
        self.game_results.append(GameResult("Team10", 10, KindOfSport.Hockey, AgeSection.Junior))



class Task2(QFrame, Ui_Task2):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.calculateButton.clicked.connect(self.calculate_click)

    def calculate_click(self):
        exam_scores = (
            int(self.mark1.text()),
            int(self.mark2.text()),
            int(self.mark3.text()),
            int(self.mark4.text()),
            int(self.mark5.text()),
            int(self.mark6.text())
        )

        result = self.get_rating(self.lineEdit.text(), exam_scores, float(self.coefficient.text()))
        QMessageBox.information(self, 'Result', result)

    @staticmethod
    def get_rating(student, exam_scores, diligence_coefficient):
        average_score = mean(exam_scores)

        grade = average_score + 1.25 * diligence_coefficient

        rounded_grade = round(grade, 1)

        result = f"Рейтинг студента {student} рівний {rounded_grade}"

        return result
    
class Task3(QFrame, Ui_Task3):
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

        self.tabWidget.addTab(self.tab1, "Task 1")
        self.tabWidget.addTab(self.tab2, "Task 2")
        self.tabWidget.addTab(self.tab3, "Task 3")


if __name__ == "__main__":
    import sys
    app = QApplication(sys.argv)
    mainWindow = MainWindow()
    mainWindow.show()
    sys.exit(app.exec_())
