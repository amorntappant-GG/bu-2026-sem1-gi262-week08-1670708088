using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        #region Lecture

        public int LCT01_RecursiveFactorial(int n)
        {
            return Factorial(n);
        }

        private int Factorial(int n)
        {
            // factorial(5) = 5 * 4 .. 1 => 5 * fact(4)
            if (n == 0) return 1; // base case
            if (n == 1) return 1; // base case
            return n * Factorial(n - 1); // recursive case
        }

        public int LCT02_RecursiveFibonacci(int n)
        {
            return Fibonacci(n);
        }

        private int Fibonacci(int n)
        {
            // base case
            if (n == 0) return 0; // base case
            if (n == 1) return 1; // base case

            // recursive case
            // fib(5) = fib(4) + fib(3)
            // fib(4) = fib(3) + fib(2)
            // fib(2) = fib(1) + fib(0)
            // fib(n) = fib(n-1) + fib(n-2)
            return Fibonacci(n - 1) + Fibonacci(n - 2); // recursive case
        }

        public int LCT03_RecursiveSumOfOneToN(int n)
        {
            // n = 5 => 5 + 4 + 3 + 2 + 1
            // = >5 + sum(4).
            // => = 4 + sum(3)
            // => n+ sum(n-1)
            // base case =>2+ sum(1) => 1
            return SumOfOneToN(n);
        }

        private int SumOfOneToN(int n)
        {
            // base case
            //if (n == 0) return 0;
            // if (n == 1) return 1;
            if (n <= 1) return n;

            // recursive case

            return n + SumOfOneToN(n - 1); // recursive case
        }

        public int LCT04_RecursiveSumOfNumbers(int[] numbers)
        {
            return SumOfNumbers(numbers, 0);
        }

        private int SumOfNumbers(int[] numbers, int index)
        {
            // base case
            // numbers = [1, 2, 3, 4, 5]
            // sum = numbers[0] + sum(numbers[1]+ ...+ numbers[4])
            // sum = numbers[n-1] + sum(numbers[n-2]+ ...+ numbers[0])
            // sum = numbers[n-1] + sum(n-2)
            // base case
            if (index >= numbers.Length) return 0;
            // recursive case

            return numbers[index] + SumOfNumbers(numbers, index + 1); // recursive case
        }

        #endregion

        #region Assignment

        public int ASN01_RecursivePower(int baseNum, int exponent)
        {
            return Power(baseNum, exponent);
        }

        private int Power(int baseNum, int exponent)
        {
            // Base Case: ยกกำลัง 0 ได้ 1
            if (exponent == 0) return 1;

            // Recursive Case: baseNum × Power(baseNum, exponent - 1)
            return baseNum * Power(baseNum, exponent - 1);
        }

        public bool ASN02_IsPalindrome(string str)
        {
            return IsPalindrome(str, 0, str.Length - 1);
        }

        private bool IsPalindrome(string str, int start, int end)
        {
            // Base Case: ตำแหน่งมาชนกันหรือข้ามกัน แปลว่าตรวจครบแล้ว
            if (start >= end) return true;

            // ถ้าตัวหน้าและตัวหลังไม่เหมือนกัน → ไม่ใช่ Palindrome
            if (str[start] != str[end]) return false;

            // Recursive Case: ขยับเข้าหาตรงกลาง
            return IsPalindrome(str, start + 1, end - 1);
        }

        public int ASN03_RecursiveGCD(int a, int b)
        {
            return GCD(a, b);
        }

        private int GCD(int a, int b)
        {
            // Base Case: เมื่อ b เป็น 0 คำตอบคือ a
            if (b == 0) return a;

            // Recursive Case: เปลี่ยนเป็น GCD(b, a % b)
            return GCD(b, a % b);
        }

        public int ASN04_RecursiveBinarySearch(int[] arr, int target)
        {
            return BinarySearch(arr, target, 0, arr.Length - 1);
        }

        private int BinarySearch(int[] arr, int target, int low, int high)
        {
            // Base Case: ขอบเขตผิด แปลว่าไม่พบข้อมูล
            if (low > high) return -1;

            // หาตำแหน่งตรงกลาง
            int mid = low + (high - low) / 2;

            // เจอ target
            if (arr[mid] == target)
                return mid;

            // target น้อยกว่า → ค้นหาฝั่งซ้าย
            if (arr[mid] > target)
                return BinarySearch(arr, target, low, mid - 1);

            // target มากกว่า → ค้นหาฝั่งขวา
            return BinarySearch(arr, target, mid + 1, high);
        }

        #endregion

    }
}