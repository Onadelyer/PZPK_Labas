# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file './Task2.ui'
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
        self.inputBox = QtWidgets.QPlainTextEdit(Frame)
        self.inputBox.setGeometry(QtCore.QRect(10, 10, 381, 191))
        self.inputBox.setObjectName("inputBox")
        self.outputBox = QtWidgets.QPlainTextEdit(Frame)
        self.outputBox.setGeometry(QtCore.QRect(410, 10, 381, 191))
        self.outputBox.setObjectName("outputBox")
        self.label = QtWidgets.QLabel(Frame)
        self.label.setGeometry(QtCore.QRect(180, 210, 71, 31))
        font = QtGui.QFont()
        font.setPointSize(14)
        self.label.setFont(font)
        self.label.setObjectName("label")
        self.label_2 = QtWidgets.QLabel(Frame)
        self.label_2.setGeometry(QtCore.QRect(570, 210, 71, 31))
        font = QtGui.QFont()
        font.setPointSize(14)
        self.label_2.setFont(font)
        self.label_2.setObjectName("label_2")
        self.generateButton = QtWidgets.QPushButton(Frame)
        self.generateButton.setGeometry(QtCore.QRect(320, 310, 161, 51))
        self.generateButton.setObjectName("generateButton")

        self.retranslateUi(Frame)
        QtCore.QMetaObject.connectSlotsByName(Frame)

    def retranslateUi(self, Frame):
        _translate = QtCore.QCoreApplication.translate
        Frame.setWindowTitle(_translate("Frame", "Frame"))
        self.label.setText(_translate("Frame", "TF_1"))
        self.label_2.setText(_translate("Frame", "TF_2"))
        self.generateButton.setText(_translate("Frame", "Generate text"))


if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    Frame = QtWidgets.QFrame()
    ui = Ui_Frame()
    ui.setupUi(Frame)
    Frame.show()
    sys.exit(app.exec_())
