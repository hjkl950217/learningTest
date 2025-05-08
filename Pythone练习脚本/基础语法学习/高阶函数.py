from functools import partial


def calculate_and_print(num, calculator):
    result = calculator(num)
    print(
        f"""
    | 数字参数 | {num:=2} |
    | 计算结果 | {result} |"""
    )


def calculate_square(num):
    return num**2


def calculate_cube(num):
    return num * num * num


def calculate_power(num, power):
    return num**power


calculate_and_print(5, calculate_square)
calculate_and_print(5, lambda num: num**2)


# ======================函数组合======================
def compose(*funcs):
    """
    *和**说明
    如果调用 new_func(2, 3)，args 是 (2, 3)，kwargs 是 {}。
    如果调用 new_func(x=2, y=3)，args 是 ()，kwargs 是 {'x': 2, 'y': 3}。"""

    def inner(*args, **kwargs):
        """
        执行一系列函数，并返回最终结果。

        参数:
            *args (tuple): 初始参数，传递给第一个函数。
            **kwargs (dict): 关键字参数，传递给第一个函数。

        返回:
            结果: 第一个函数的返回值经过后续函数处理后的最终结果。
        """
        # 执行第一个函数（允许多参数）
        result = funcs[0](*args, **kwargs)
        # 依次执行后续函数（单参数）
        for f in funcs[1:]:
            result = f(result)
        return result

    return inner


# 示例函数
def add(x, y):
    return x + y


def square(x):
    return x**2


# 中间函数：接收 2 个参数
def multiply(x, y):
    return x * y


# 组合：add → multiply → square
# 用 partial 固定 multiply 的第二个参数
new_func = compose(add, partial(multiply, y=10), square)
print("组合函数输出结果：" + str(new_func(2, 3)))
