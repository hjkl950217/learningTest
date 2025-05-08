# f = open("./data.txt", "w", encoding="utf-8") # w为覆盖 a为追加 r+为读取的同时覆盖写入内容

f = open("poem.txt", "w", encoding="utf-8")
f.write("我欲乘风归去,\n")
f.write("又恐琼楼玉宇,\n")
f.write("高处不胜寒。")
f.close()

f = open("poem.txt", "a", encoding="utf-8")
f.write("起舞弄清影，\n")
f.write("何似在人间。")
f.close()
