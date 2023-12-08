from PyQt5.QtWidgets import QWidget, QGridLayout, QTextEdit, QTableView, QListView, QLabel

class Task4(QWidget):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Task4")
        self.setGeometry(100, 100, 800, 450)

        layout = QGridLayout(self)

        adjacencyMatrixLabel = QLabel("Матриця суміжності:", self)
        incidenceMatrixLabel = QLabel("Матриця інцидентності:", self)
        edgeListLabel = QLabel("Список ребер:", self)

        self.adjacencyMatrixDataGrid = QTableView(self)
        self.incidenceMatrixDataGrid = QTableView(self)
        self.edgeListListView = QListView(self)

        layout.addWidget(adjacencyMatrixLabel, 0, 0)
        layout.addWidget(self.adjacencyMatrixDataGrid, 1, 0)
        layout.addWidget(incidenceMatrixLabel, 2, 0)
        layout.addWidget(self.incidenceMatrixDataGrid, 3, 0)
        layout.addWidget(edgeListLabel, 4, 0)
        layout.addWidget(self.edgeListListView, 5, 0)

        # Populate data grids and list view as needed
