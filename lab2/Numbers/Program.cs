﻿using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Denysenko Mark IP - 61";

            ArithmeticTest();

            ColectionTest();

            StackOverflowTest();

            Console.ReadKey();
        }

        #region Test fucntions

        static void ArithmeticTest()
        {
            Console.WriteLine("\tTesting arithmetic operators:");
            Integer n1 = new Integer(5);
            Integer n2 = new Integer(10);

            Real n3 = new Real(7.5);
            Real n4 = new Real(3.5);

            Console.WriteLine($"Get hashcode {n2} -> {n2.GetHashCode()}");
            Console.WriteLine($"Get hashcode {n3} -> {n3.GetHashCode()}");

            Console.WriteLine($" {n1} + {n2} = {n1 + n2}");
            Console.WriteLine($" {n3} - {n4} = {n3 - n4}");
            Console.WriteLine($" {n1} + {n4} = {n1 + n4}");
            Console.WriteLine($" {n4} - {n1} = {n4 - n1}");

            Console.WriteLine($" {n1} * {n2} = {n1 * n2}");
            Console.WriteLine($" {n3} / {n4} = {n3 / n4}");
            Console.WriteLine($" {n2} * {n4} = {n2 * n4}");

            Console.WriteLine("\tTesting equals and operators ==, !=");
            Integer n11 = n1.Clone() as Integer;
            Real n33 = n3.Clone() as Real;

            Console.WriteLine($" {n1} == {n11} -> {n1 == n11}");
            Console.WriteLine($" {n1} == {n2} -> {n1 == n2}");
            Console.WriteLine($" {n3} != {n33} -> {n3 != n33}");
            Console.WriteLine($" {n3} != {n1} -> {n3 != n1}");
        }

        static void ColectionTest()
        {
            Console.WriteLine("\tTesting collection Series");
            Series<Integer> testSeries = new Series<Integer>();

            for (int i = 0; i < 10; i++)
            {
                testSeries.Add(new Integer(i));
            }

            testSeries.ShowInfo();

            Console.WriteLine("Making deep copy and modify (multiply on 2) it!");

            Series<Integer> testSeries2 = testSeries.DeepCopy();

            for(int i = 0; i < testSeries2.Count; i++)
            {
                testSeries2[i].Number = testSeries2[i].Number * 2;
            }
            Console.WriteLine("Second collection: ");
            testSeries2.ShowInfo();

            Console.WriteLine("First collection without changing");
            testSeries.ShowInfo();

            Console.WriteLine("\tTesting Exceptions");
            try
            {
                testSeries.Delete(11);
            }
            catch(Exceptions.MyIndexOutOfRangeException ex)
            {
                Console.WriteLine("Testing index out of range! " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some another exeption! " + ex.Message);
            }
        }

        static void StackOverflowTest()
        {
            try
            {
                Recursive();
            }
            catch (Exceptions.MyStackOverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Recursive(int counter = 0)
        {
            counter++;
            if (counter < 100)                      // deep for recursion
            {
                Recursive(counter);
            }
            else
            {
                throw new Exceptions.MyStackOverflowException("My stackoverflow test exception! Deep: " + counter);
            }
        }

        #endregion
    }
}
