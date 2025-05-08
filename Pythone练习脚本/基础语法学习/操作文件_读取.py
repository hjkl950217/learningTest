f = open("./data.txt", "r", encoding="utf-8")
print(f.read())  # 读取全部
print(f.read(3))  # 读取前三个字符
print(f.readline())  # 读取一行
print(f.readlines())  # 读取全部行
f.close()  # 关闭文件


# with open("./data.txt", "r", encoding="utf-8") as f:
#     print(f.read())
#     print(f.read(3))
#     print(f.readline())
#     print(f.readlines())
# # 不需要手动关闭文件
