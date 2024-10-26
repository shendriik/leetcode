import unittest
from typing import List

class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        x = 0
        y = 0
        temp = []
        for i in range(0, n + m):
            if nums1[x] <= nums2[y]:
                temp.append(nums1[x])
                x +=1
            else:
                temp.append(nums2[y])
                y +=1
        for i in range(0, n + m):
            nums1[i] = temp[i]

class TestSolution(unittest.TestCase):
    def test_merge(self):
        solution = Solution()

        nums1 = [1, 2, 3, 0, 0, 0]
        nums2 = [2, 5, 6]
        m = 3
        n = 3
        solution.merge(nums1, m, nums2, n)
        self.assertEqual(nums1, [1, 2, 2, 3, 5, 6])

    def test_merge_with_empty_nums2(self):
        solution = Solution()

        nums1 = [1, 2, 3, 0, 0, 0]
        nums2 = []
        m = 3
        n = 0
        solution.merge(nums1, m, nums2, n)
        self.assertEqual(nums1, [1, 2, 3])

    def test_merge_with_empty_nums1(self):
        solution = Solution()

        nums1 = [0, 0, 0]
        nums2 = [2, 5, 6]
        m = 0
        n = 3
        solution.merge(nums1, m, nums2, n)
        self.assertEqual(nums1, [2, 5, 6])

    def test_merge_with_single_elements(self):
        solution = Solution()

        nums1 = [1, 0]
        nums2 = [2]
        m = 1
        n = 1
        solution.merge(nums1, m, nums2, n)
        self.assertEqual(nums1, [1, 2])

if __name__ == '__main__':
    unittest.main()
