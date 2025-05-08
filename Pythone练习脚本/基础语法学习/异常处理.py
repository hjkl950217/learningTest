try:
    user_weight = float(input("请输入体重(单位：kg)"))
    user_height = float(input("请输入身高(单位：m)"))
    bmi = user_weight / (user_height**2)
except ValueError:  # 捕获输入不是数字的异常
    print("输入的不是数字，请重新输入")
except ZeroDivisionError:  # 捕获除数为0的异常
    print("除数不能为0")
except:  # 捕获所有异常
    print("发生异常")
else:  # 没有发生异常时执行
    print(f"BMI指数为：{bmi}")
finally:  # 无论是否发生异常，都会执行
    print("程序结束")
