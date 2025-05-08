name = "老林"
year = "虎"

message_content = """
律回春渐，新元肇启。
新岁甫至，福气东来。
金{0}贺岁，欢乐祥瑞
金{0}敲门,五福临门。
给{1}及家人拜年啦！
新春快乐，{0}年大吉！
""".format(
    year, name
)
print("第一种格式化：\n" + message_content)


message_content = """
律回春渐，新元肇启。
新岁甫至，福气东来。
金{year}贺岁，欢乐祥瑞
金{year}敲门,五福临门。
给{name}及家人拜年啦！
新春快乐，{year}年大吉！
""".format(
    year=year, name=name
)
print("第二种格式化：\n" + message_content)


message_content = f"""
律回春渐，新元肇启。
新岁甫至，福气东来。
金{year}贺岁，欢乐祥瑞
金{year}敲门,五福临门。
给{name}及家人拜年啦！
新春快乐，{year}年大吉！
"""
print("第三种格式化：\n" + message_content)

# 用于字典
gpa_dict = {"小明":3.251,"小花":3.869,"小李":2.683,"小张":3.685}
for name, gpa in gpa_dict.items():
    print("{0}你好，你的当前绩点为：{1:.2f}".format(name,gpa))
    print(f"{name}你好，你的当前绩点为：{gpa:.2f}")
