# BMI = 体重 / (身高 ** 2)
user_weight = float(input("请输入体重（单位：KG）:"))
user_height = float(input("请输入身高（单位：cm）："))
user_BMI = user_weight / (user_height / 100) ** 2
print("BMI:" + str(user_BMI))
