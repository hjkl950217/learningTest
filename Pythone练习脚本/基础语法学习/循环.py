# for循环
total = 0
for i in range(1, 101, 1):  # rang 起始1 生成1到100 不包含101 步长为1
    total += i
print(total)


dic = {"100": 36, "101": 36.2, "102": 37.1}
for key, val in dic.items():
    print(key, val)


# while循环
print("---while循环--")
total2 = 0
while total2 != 100:
    total2 += 1
print(total2)


print("我是一个求平均值的程序。")
total = 0
count = 0
user_input = input("请输入数字（完成所有数字输入后，请输入q终止程序）：")
while user_input != "q":
    num = float(user_input)
    total += num
    count += 1
    user_input = input("请输入数字（完成所有数字输入后，请输入q终止程序）：")

if total == 0 or count == 0:
    result = 0
else:
    result = total / count
print("平均值为：", result)
