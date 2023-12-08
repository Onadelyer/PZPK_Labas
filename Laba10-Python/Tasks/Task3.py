from PyQt5.QtWidgets import QWidget, QLabel, QPushButton, QVBoxLayout, QHBoxLayout, QLineEdit, QMessageBox
import random

class TreeNode:
    def __init__(self, day):
        self.day = day
        self.left = None
        self.right = None

class Task3(QWidget):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Task3")
        self.setGeometry(100, 100, 800, 450)

        self.root = None  # Initialize the root node
        self.initialize_tree()  # Initialize the tree with default schedule

        layout = QVBoxLayout(self)

        inputLabel = QLabel("Enter a day", self)
        self.inputTextBox = QLineEdit(self)
        addDayButton = QPushButton("Add Day", self)
        removeDayButton = QPushButton("Remove Day", self)
        traverseTreeButton = QPushButton("Traverse Tree", self)
        searchLabel = QLabel("Enter a day to search", self)
        self.searchTextBox = QLineEdit(self)
        searchButton = QPushButton("Search Day", self)

        buttonLayout = QHBoxLayout()
        buttonLayout.addWidget(addDayButton)
        buttonLayout.addWidget(removeDayButton)
        buttonLayout.addWidget(traverseTreeButton)

        layout.addWidget(inputLabel)
        layout.addWidget(self.inputTextBox)
        layout.addWidget(addDayButton)
        layout.addWidget(removeDayButton)
        layout.addWidget(traverseTreeButton)
        layout.addWidget(searchLabel)
        layout.addWidget(self.searchTextBox)
        layout.addWidget(searchButton)

        addDayButton.clicked.connect(self.AddDay_Click)
        removeDayButton.clicked.connect(self.RemoveDay_Click)
        traverseTreeButton.clicked.connect(self.TraverseTree_Click)
        searchButton.clicked.connect(self.SearchDay_Click)

    def initialize_tree(self):
        default_schedule = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"]
        for day in default_schedule:
            self.add_day_to_tree(day)

    def add_day_to_tree(self, day):
        self.root = self.add_day_recursive(self.root, day)

    def add_day_recursive(self, node, day):
        if node is None:
            return TreeNode(day)

        if day.lower() < node.day.lower():
            node.left = self.add_day_recursive(node.left, day)
        elif day.lower() > node.day.lower():
            node.right = self.add_day_recursive(node.right, day)

        return node

    def remove_day(self, day):
        self.root = self.remove_day_recursive(self.root, day)

    def remove_day_recursive(self, node, day):
        if node is None:
            return node

        if day.lower() < node.day.lower():
            node.left = self.remove_day_recursive(node.left, day)
        elif day.lower() > node.day.lower():
            node.right = self.remove_day_recursive(node.right, day)
        else:
            if node.left is None:
                return node.right
            elif node.right is None:
                return node.left

            node.day = self.find_min_value(node.right).day
            node.right = self.remove_day_recursive(node.right, node.day)

        return node

    def find_min_value(self, node):
        while node.left is not None:
            node = node.left
        return node

    def traverse_tree(self):
        result = []
        self.traverse_tree_recursive(self.root, result)
        return result

    def traverse_tree_recursive(self, node, result):
        if node is not None:
            self.traverse_tree_recursive(node.left, result)
            result.append(node.day)
            self.traverse_tree_recursive(node.right, result)

    def search_day(self, day):
        return self.search_day_recursive(self.root, day)

    def search_day_recursive(self, node, day):
        if node is None:
            return False

        compare_result = day.lower() == node.day.lower()

        if compare_result < 0:
            return self.search_day_recursive(node.left, day)
        elif compare_result > 0:
            return self.search_day_recursive(node.right, day)
        else:
            return True

    def AddDay_Click(self):
        day = self.inputTextBox.text().strip()
        if day:
            self.add_day_to_tree(day)
            self.inputTextBox.clear()

    def RemoveDay_Click(self):
        day = self.inputTextBox.text().strip()
        if day:
            self.remove_day(day)
            self.inputTextBox.clear()

    def TraverseTree_Click(self):
        schedule = self.traverse_tree()
        QMessageBox.information(self, "Schedule", f"Schedule: {', '.join(schedule)}")

    def SearchDay_Click(self):
        day = self.searchTextBox.text().strip()
        if day:
            found = self.search_day(day)
            message = f"{day} found in the schedule." if found else f"{day} not found in the schedule."
            QMessageBox.information(self, "Search Result", message)
            self.searchTextBox.clear()

if __name__ == '__main__':
    import sys
    from PyQt5.QtWidgets import QApplication

    app = QApplication(sys.argv)
    window = Task3()
    window.show()
    sys.exit(app.exec_())
