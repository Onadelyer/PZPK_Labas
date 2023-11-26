from PyQt5.QtWidgets import QApplication, QWidget, QVBoxLayout, QLabel, QMessageBox
from abc import ABC, abstractmethod
import random

class IProduct(ABC):
    @abstractmethod
    def install(self):
        pass

    @abstractmethod
    def update(self, label):
        pass


class IDeveloper(ABC):
    @abstractmethod
    def write_code(self):
        pass

    @abstractmethod
    def test_code(self):
        pass


class Plant(IProduct, ABC):
    def __init__(self):
        self.Name = ""
        self.Type = ""
        self.OnTheVergeOfExtinction = False

    @abstractmethod
    def grow(self):
        pass

    @abstractmethod
    def blossom(self):
        pass

    def photosynthesize(self):
        QMessageBox.information(None, "Photosynthesize", f"{self.Name} фотосинтезує")

    def __str__(self):
        return f"Name:{self.Name} Type:{self.Type} In Red List:{self.OnTheVergeOfExtinction}"


class Tree(Plant):
    def __init__(self):
        super().__init__()
        self.LeavesFallInAutumn = False

    def grow(self):
        pass

    def blossom(self):
        pass

    def __str__(self):
        return f"{super().__str__()} Are leaves fall in autumn:{self.LeavesFallInAutumn}"


class Flowers(Plant):
    def __init__(self):
        super().__init__()
        self.Color = ""

    def grow(self):
        pass

    def blossom(self):
        pass

    def __str__(self):
        return f"{super().__str__()} Color:{self.Color}"


class PlantDatabase:
    def __init__(self):
        self._plants = []

    def add_plant(self, plant):
        self._plants.append(plant)

    def display_information_on_screen(self, label):
        result_text = '\n'.join(str(p) for p in self._plants)
        label.setText(result_text)

    def display_plants_on_the_verge_of_extinction(self, label):
        result_text = '\n'.join(str(p) for p in self._plants if p.OnTheVergeOfExtinction)
        label.setText(result_text)

    def find_endangered_species(self):
        return [p for p in self._plants if isinstance(p, (Tree, Flowers))]

    def generate_plants(self):
        if self._plants:
            return

        plants_list = []

        random.seed()

        for i in range(1, 11):
            tree = Tree()
            tree.Name = f"Tree{i}"
            tree.Type = "Deciduous"
            tree.LeavesFallInAutumn = i % 2 == 0
            tree.OnTheVergeOfExtinction = random.choice([True, False])
            plants_list.append(tree)

        for i in range(1, 11):
            flower = Flowers()
            flower.Name = f"Flower{i}"
            flower.Type = "Perennial"
            flower.Color = "Red" if i % 2 == 0 else "Blue"
            flower.OnTheVergeOfExtinction = random.choice([True, False])
            plants_list.append(flower)

        self._plants = plants_list