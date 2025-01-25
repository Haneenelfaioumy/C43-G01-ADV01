using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System;

namespace Assignment01
{
    internal class Program
    {
        #region Functions
        public static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;
            //list.Count refers to the number of elements in a collection, such as a list or an array.

            while (left < right)
            {
                // Swap elements at left and right indices
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                // Move pointers toward the center
                left++;
                right--;
            }
        }

        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }

        public static int FindFirstNonRepeatedCharacter(string str)
        {
            // Dictionary to store character counts
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count the occurrences of each character in the string
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Iterate through the string to find the first non-repeated character
            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[str[i]] == 1)
                {
                    return i; // Return the index of the first non-repeated character
                }
            }

            return -1; // Return -1 if no non-repeated character is found
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1.Create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. 
            /*
            The range should support basic operations such as checking if a value is within the range and 
            determining the length of the range. Requirements: 
            ● Create a generic class named Range<T> where T represents the type of values. 
            ● Implement a constructor that takes the minimum and maximum  values to define the range. 
            ● Implement a method IsInRange(T value) that returns true if the given value is within the range
             ,otherwise false. 
            ● Implement a method Length() that returns the length of the range 
            (the difference between the maximum and minimum values). 
            ● Note: 
            You can assume that the type T used in the Range<T> class implements the IComparable<T> interface 
            to allow for comparisons.
            */

            //// Integer range
            //Range<int> intRange = new Range<int>(10, 1);
            //Console.WriteLine($"Min: {intRange.Min}, Max: {intRange.Max}"); // Min: 1, Max: 10
            //Console.WriteLine($"Is 5 in range? {intRange.IsInRange(5)}"); // True
            //Console.WriteLine($"Length: {intRange.Length()}"); // 9.0

            //// Double range
            //Range<double> doubleRange = new Range<double>(5.5, 0.5);
            //Console.WriteLine($"Min: {doubleRange.Min}, Max: {doubleRange.Max}"); // Min: 0.5, Max: 5.5
            //Console.WriteLine($"Is 3.0 in range? {doubleRange.IsInRange(3.0)}"); // True
            //Console.WriteLine($"Length: {doubleRange.Length()}"); // 5.0

            //// Decimal range
            //Range<decimal> decimalRange = new Range<decimal>(1.2m, 4.8m);
            //Console.WriteLine($"Min: {decimalRange.Min}, Max: {decimalRange.Max}"); // Min: 1.2, Max: 4.8
            //Console.WriteLine($"Is 3.0 in range? {decimalRange.IsInRange(3.0m)}"); // True
            //Console.WriteLine($"Length: {decimalRange.Length()}"); // 3.6

            #endregion

            #region Q2.You are given an ArrayList containing a sequence of elements. 
            /*
            try to reverse the order of elements in the ArrayList in-place (in the same arrayList) without 
            using the built-in Reverse.Implement a function that takes the ArrayList as input and modifies 
            it to have the reversed order of elements.
            */

            //ArrayList list01 = new ArrayList { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Original ArrayList:");
            //foreach (var item in list01)
            //{
            //    Console.Write(item + " , ");
            //}

            //ReverseArrayList(list01);

            //Console.WriteLine("\nReversed ArrayList:");
            //foreach (var item in list01)
            //{
            //    Console.Write(item + " , ");
            //}

            //Console.WriteLine("\n=================================================================");

            //// Example with strings
            //ArrayList list02 = new ArrayList { "apple", "banana", "cherry", "date", "elderberry" };

            //Console.WriteLine("Original ArrayList:");
            //foreach (var item in list02)
            //{
            //    Console.Write(item + " , ");
            //}

            //ReverseArrayList(list02);

            //Console.WriteLine("\nReversed ArrayList:");
            //foreach (var item in list02)
            //{
            //    Console.Write(item + " , ");
            //}

            #endregion

            #region Q3.You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //// Example list of integers
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine("Original List:");
            //foreach (var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //List<int> evenNumbers = GetEvenNumbers(numbers);

            //Console.WriteLine("\nEven Numbers:");
            //foreach (var number in evenNumbers)
            //{
            //    Console.Write(number + " ");
            //}

            #endregion

            #region Q4.implement a custom list called FixedSizeList<T> with a predetermined capacity.This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
            /*
            Requirements: 
            ● Create a generic class named FixedSizeList<T>. 
            ● Implement a constructor that takes the fixed capacity of the list as 
                a  
            ● parameter. 
            ● Implement an Add method that adds an element to the list, but 
            throws an exception if the list is already full. 
            ● Implement a Get method that retrieves an element at a specific 
            index in the list but throws an exception for invalid indices.
            */

            //try
            //{
            //    // Create a FixedSizeList of integers with a capacity of 3
            //    FixedSizeList<int> list = new FixedSizeList<int>(3);

            //    // Add elements to the list
            //    list.Add(10);
            //    list.Add(20);
            //    list.Add(30);

            //    Console.WriteLine("Current elements in the list:");
            //    for (int i = 0; i < list.Count(); i++)
            //    {
            //        Console.WriteLine($"Element at index {i}: {list.Get(i)}");
            //    }

            //    // Try adding another element to the full list
            //    list.Add(40);  // This will throw an exception

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    // Try accessing an invalid index
            //    FixedSizeList<int> list2 = new FixedSizeList<int>(2);
            //    list2.Add(10);
            //    list2.Add(20);
            //    Console.WriteLine(list2.Get(5)); // This will throw an exception
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Q5.Given a string, find the first non-repeated character in it and return its index.If there is no such character, return
            //Hint: you can use dictionary

            //string input = "swiss";
            ////string input = "aabbcc";
            //int result = FindFirstNonRepeatedCharacter(input);

            //if (result != -1)
            //{
            //    Console.WriteLine($"The first non-repeated character is at index {result}: '{input[result]}'");
            //}
            //else
            //{
            //    Console.WriteLine("No non-repeated character found.");
            //}

            #endregion
        }
    }
}
