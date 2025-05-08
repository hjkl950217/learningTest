class Mammal:
    """
    哺乳动物
    """

    def __init__(self, name, sex):
        self.name = name
        self.sex = sex
        self.num_eyes = 2

    def breathe(self):
        print(f"{self.name} 在呼吸")

    def poop(self):
        print(f"{self.name} 在排泄")


class Human(Mammal):
    def __init__(self, name, sex):
        super().__init__(name, sex)
        self.has_tail = False

    def read(self):
        print(f"{self.name} 在阅读")


class Cat(Mammal):
    def __init__(self, name, sex):
        super().__init__(name, sex)
        self.has_tail = True

    def scratch_sofa(self):
        print(f"{self.name} 在抓沙发")
