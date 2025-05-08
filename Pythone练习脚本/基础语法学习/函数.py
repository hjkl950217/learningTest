
def calculate_sector(central_angle, radius):
    """
    计算扇形的面积

    参数:
    central_angle (float): 圆心角，单位为度
    radius (float): 半径

    返回:
    float: 扇形的面积
    """
    # 计算扇形的面积，公式为：扇形面积=圆心角/360*π*半径^2
    sector_area = central_angle / 360 * 3.14 * radius**2
    # 返回扇形的面积
    return sector_area

sector_area1 = calculate_sector(60, 5)
print(sector_area1)

sector_area2 = calculate_sector(120, 10)
print(sector_area2)


# 计算BMI的函数
def calculate_bmi(weight, height):
    bmi = weight / (height / 100) ** 2
    print(f"计算出的BMI为：{bmi}")

    if bmi <= 18.5:
        category = "偏瘦"
    elif bmi <= 25:
        category = "正常"
    elif bmi <= 30:
        category = "偏胖"
    else:
        category = "肥胖"

    return (bmi, category)


print(calculate_bmi(70, 170))
