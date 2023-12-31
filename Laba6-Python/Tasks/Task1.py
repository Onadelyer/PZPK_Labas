from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_Frame(object):
    def setupUi(self, Frame):
        Frame.setObjectName("Frame")
        Frame.resize(800, 600)
        self.resultLabel = QtWidgets.QLabel(Frame)
        self.resultLabel.setGeometry(QtCore.QRect(100, 100, 500, 61))
        font = QtGui.QFont()
        font.setPointSize(18)
        self.resultLabel.setFont(font)
        self.resultLabel.setObjectName("resultLabel")
        self.increaseButton = QtWidgets.QPushButton(Frame)
        self.increaseButton.setGeometry(QtCore.QRect(100, 220, 111, 41))
        self.increaseButton.setObjectName("increaseButton")
        self.decreaseButton = QtWidgets.QPushButton(Frame)
        self.decreaseButton.setGeometry(QtCore.QRect(240, 220, 141, 41))
        self.decreaseButton.setObjectName("decreaseButton")

        self.retranslateUi(Frame)
        QtCore.QMetaObject.connectSlotsByName(Frame)

    def retranslateUi(self, Frame):
        _translate = QtCore.QCoreApplication.translate
        Frame.setWindowTitle(_translate("Frame", "Frame"))
        self.resultLabel.setText(_translate("Frame", "TextLabel"))
        self.increaseButton.setText(_translate("Frame", "Increase year"))
        self.decreaseButton.setText(_translate("Frame", "Decrease day by 2"))


if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    Frame = QtWidgets.QFrame()
    ui = Ui_Frame()
    ui.setupUi(Frame)
    Frame.show()
    sys.exit(app.exec_())
