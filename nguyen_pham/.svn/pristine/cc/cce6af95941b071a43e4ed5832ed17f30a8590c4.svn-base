import unittest

from PerfectNumberChecker import *


class PerfectNumberChecker(unittest.TestCase):
    def test_canary(self):
        self.assertTrue(True)
        
    def test_sum_of_factors_of_1_is_1(self):
        sample = [
            (6, 12),
            (50, 93),
        ]
        for number, expected in sample:
            self.assertEqual(sum_of_factors(number), expected)

    def set_for_is_perfect(self, is_perfect):
        sample = [
            (6, True),
            (28, True),
            (50, False),
            (100, False),
            (496, True),
            (500, False),
            (8128, True),
        ]
        for number, expected in sample:
            self.assertEqual(is_perfect(number), expected)
    
    def test_for_is_perfect_imperative(self):
        self.set_for_is_perfect(is_perfect_imperative)
    
    def test_for_is_perfect_functional(self):
        self.set_for_is_perfect(is_perfect_functional)