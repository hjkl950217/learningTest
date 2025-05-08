import unittest
from 函数 import calculate_bmi


class TestBMI(unittest.TestCase):
    def test_bmi_ok(self):
        result = calculate_bmi(70, 175)
        self.assertAlmostEqual(result[0], 22.85, delta=0.01)

    def test_bmi_error(self):
        result = calculate_bmi(70, 175)
        self.assertNotAlmostEqual(result[0], 20, delta=0.01)


class ShoppingList:
    """初始化购物清单，shopping_List是字典类型，包含商品名和对应价格
    例子：{"牙刷"：5，"沐浴露"：15，"电池"：7}"""

    def __init__(self, shopping_list):
        self.shopping_list = shopping_list

    def get_item_count(self):
        """返回购物清单上有多少项商品"""
        return len(self.shopping_list)

    def get_total_price(self):
        """返回购物清单商品价格总额数字"""
        total_price = 0
        for price in self.shopping_list.values():
            total_price += price
        return total_price


class TestShoppingList(unittest.TestCase):
    def setUp(self):
        self.shopping_list = ShoppingList({"牙刷": 5, "沐浴露": 15, "电池": 7})

    def test_get_item_count(self):
        self.assertEqual(self.shopping_list.get_item_count(), 3)

    def test_get_total_price(self):
        self.assertEqual(self.shopping_list.get_total_price(), 27)


if __name__ == "__main__":
    unittest.main()
