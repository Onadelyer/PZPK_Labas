from PyQt5.QtWidgets import QApplication, QWidget, QMessageBox, QLabel


class IProduct:
    def __init__(self):
        self.Name = ""
        self.Version = 0.0

    def install(self):
        QMessageBox.information(None, "Install", "Installing...")

    def update(self, label):
        raise NotImplementedError("Update method must be implemented in the derived class")


class IDeveloper:
    def __init__(self):
        self.DeveloperName = ""
        self.ProgrammingLanguage = ""

    def write_code(self):
        raise NotImplementedError("WriteCode method must be implemented in the derived class")

    def test_code(self):
        raise NotImplementedError("TestCode method must be implemented in the derived class")


class CustomOperatingSystem(IProduct, IDeveloper):
    def __init__(self):
        super().__init__()
        self.Name = "Bubuntu"
        self.new_feature_has_been_developed = False
        self.new_feature_has_been_tested = False

    def update(self, label):
        if self.new_feature_has_been_developed and self.new_feature_has_been_tested:
            QMessageBox.information(None, "Update", "Updating OS...")
            self.Version += 0.1
            label.setText(str(self))
        else:
            if not self.new_feature_has_been_developed:
                QMessageBox.warning(None, "Update", "New feature has not been developed")
            elif not self.new_feature_has_been_tested:
                QMessageBox.warning(None, "Update", "New feature has not been tested")

    def write_code(self):
        QMessageBox.information(None, "Write Code", "Programmers are developing a new feature")
        self.new_feature_has_been_developed = True

    def test_code(self):
        if not self.new_feature_has_been_developed:
            QMessageBox.warning(None, "Test Code", "New feature has not been developed yet")
        else:
            QMessageBox.information(None, "Test Code", "New feature has been tested")
            self.new_feature_has_been_tested = True

    def reboot_system(self):
        QMessageBox.information(None, "Reboot System", "Rebooting system...")

    def add_user_to_the_system(self):
        QMessageBox.information(None, "Add User", "Adding user to the system...")

    def __str__(self):
        return f"Name: {self.Name}\nVersion: {self.Version}\nDeveloper: {self.DeveloperName}\nProgramming language: {self.ProgrammingLanguage}"


class MobileApp(IProduct, IDeveloper):
    def __init__(self):
        super().__init__()
        self.Name = "Cool app"
        self.new_feature_has_been_developed = False
        self.new_feature_has_been_tested = False

    def update(self, label):
        if self.new_feature_has_been_developed and self.new_feature_has_been_tested:
            QMessageBox.information(None, "Update", "Updating app...")
            self.Version += 0.1
            label.setText(str(self))
        else:
            if not self.new_feature_has_been_developed:
                QMessageBox.warning(None, "Update", "New feature has not been developed")
            elif not self.new_feature_has_been_tested:
                QMessageBox.warning(None, "Update", "New feature has not been tested")

    def write_code(self):
        QMessageBox.information(None, "Write Code", "Programmers are developing a new feature")
        self.new_feature_has_been_developed = True

    def test_code(self):
        if not self.new_feature_has_been_developed:
            QMessageBox.warning(None, "Test Code", "New feature has not been developed yet")
        else:
            QMessageBox.information(None, "Test Code", "New feature has been tested")
            self.new_feature_has_been_tested = True

    def turn_on_secret_china_spy_camera(self):
        pass

    def enable_root_access(self):
        pass

    def __str__(self):
        return f"Name: {self.Name}\nVersion: {self.Version}\nDeveloper: {self.DeveloperName}\nProgramming language: {self.ProgrammingLanguage}"
