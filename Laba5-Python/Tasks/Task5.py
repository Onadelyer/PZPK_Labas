# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file './Task5.ui'
#
# Created by: PyQt5 UI code generator 5.15.10
#
# WARNING: Any manual changes made to this file will be lost when pyuic5 is
# run again.  Do not edit this file unless you know what you are doing.


from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_Frame(object):
    def setupUi(self, Frame):
        Frame.setObjectName("Frame")
        Frame.resize(800, 600)
        self.variable1Box = QtWidgets.QLineEdit(Frame)
        self.variable1Box.setGeometry(QtCore.QRect(20, 50, 181, 41))
        self.variable1Box.setObjectName("variable1Box")
        self.variable2Box = QtWidgets.QLineEdit(Frame)
        self.variable2Box.setGeometry(QtCore.QRect(220, 50, 181, 41))
        self.variable2Box.setObjectName("variable2Box")
        self.resultBox = QtWidgets.QLineEdit(Frame)
        self.resultBox.setGeometry(QtCore.QRect(20, 110, 531, 41))
        self.resultBox.setObjectName("resultBox")
        self.optionBox = QtWidgets.QComboBox(Frame)
        self.optionBox.setGeometry(QtCore.QRect(420, 50, 131, 41))
        self.optionBox.setObjectName("optionBox")
        self.calculateButton = QtWidgets.QPushButton(Frame)
        self.calculateButton.setGeometry(QtCore.QRect(20, 170, 181, 41))
        self.calculateButton.setObjectName("calculateButton")
        self.loadButton = QtWidgets.QPushButton(Frame)
        self.loadButton.setGeometry(QtCore.QRect(370, 170, 181, 41))
        self.loadButton.setObjectName("loadButton")

        self.retranslateUi(Frame)
        QtCore.QMetaObject.connectSlotsByName(Frame)

    def retranslateUi(self, Frame):
        _translate = QtCore.QCoreApplication.translate
        Frame.setWindowTitle(_translate("Frame", "Frame"))
        self.calculateButton.setText(_translate("Frame", "Вирахувати результат"))
        self.loadButton.setText(_translate("Frame", "Завантажити файл"))


if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    Frame = QtWidgets.QFrame()
    ui = Ui_Frame()
    ui.setupUi(Frame)
    Frame.show()
    sys.exit(app.exec_())