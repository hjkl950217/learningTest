class CuteCat:
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def speak(self):
        """
        描述
        """
        print("喵" * self.age)


cat1 = CuteCat("Tom", 3)
print(f"猫猫的名字叫: {cat1.name}")
cat1.speak()


class Student:
    """
    描述
    """

    def __init__(self, name, student_id):
        self.name = name
        self.student_id = student_id
        self.grades = {"语文": 0, "数学": 0, "英语": 0}

    def set_grade(self, course, grade):
        """
        设置成绩

        Args:
            course (string): 成绩科目
            grade (int): 分数

        Returns:
            None
        """
        if course in self.grades:
            self.grades[course] = grade

    def print_grades(self):
        """
         打印成绩

        Args:

        Returns:
            None
        """
        print(f"{self.name}的成绩是：")
        for course, grade in self.grades.items():
            print(f"{course}: {grade}分")


stu1 = Student("张三", 1001)
stu1.set_grade("语文", 30)
stu1.print_grades()
