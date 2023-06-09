﻿using DS_AlgorithmAndProgrammingProblems.AlgorithmPrograms;
using DS_AlgorithmAndProgrammingProblems.DataStructurePrograms;

namespace DS_AlgorithmAndProgrammingProblems;

public class Program
{
    public static string filepath = @"D:\OneDrive\Desktop\bridgelabz\DS-AlgorithmAndProgrammingProblems\DS-AlgorithmAndProgrammingProblems\AlgorithmPrograms\WordFile.txt";
    static void Main(string[] args)
    {
        DataStructurePrograms.LinkedList<string> list = new DataStructurePrograms.LinkedList<string>(); 
        Console.WriteLine("DS-Algorithm and Programming Problems");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\n\nSelect option to execute \n1.Binary Search \n2.Insertion Sort \n3.Bubble Sort \n4.Merge Sort" +
                "\n5.Anagram Detection \n6.Prime Number \n7.Customize Message \n8.Balanced Parantheses \n9.Bank Cash Counter " +
                "\n10.Unordered List \n11.Ordered List \n12.Display List \n13.Search in List \n14.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch search = new BinarySearch();
                    search.ReadTextFile(filepath);
                    Console.WriteLine("Enter word you want to search");
                    string str = Console.ReadLine();
                    search.BinarySearchOperation(str);
                    break;
                case 2:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Sort();
                    break;
                case 3:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.Sort();
                    break;
                case 4:
                    MergeSort mergeSort = new MergeSort();
                    int[] arrPass = { 55, 89, 214, 62, 150, 66, 99, 33, 11, 45 };
                    Console.Write("Initial Array is: ");
                    for (int i = 0; i < arrPass.Length; i++)
                    {
                        Console.Write(arrPass[i] + " ");
                    }
                    int len = Convert.ToInt32(arrPass.Length);
                    mergeSort.Sort(arrPass, 0, len - 1);
                    Console.Write("\nSorted Array is: ");
                    for (int i = 0; i < arrPass.Length; i++)
                    {
                        Console.Write(arrPass[i] + " ");
                    }
                    break;
                case 5:
                    AnagramDetection anagramDetection = new AnagramDetection();
                    anagramDetection.Anagram();
                    break;
                case 6:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Check();
                    break;
                case 7:
                    CustomizeMessage userInput = new CustomizeMessage();
                    userInput.ReplaceString();
                    break;
                case 8:
                    BalancedParantheses balancedParantheses = new BalancedParantheses();
                    balancedParantheses.CheckParantheses();
                    break;
                case 9:
                    BankCashCounter bankCashCounter = new BankCashCounter();
                    bankCashCounter.CashCounter();
                    break;
                case 10:
                    string text = "This is a sample text";
                    string[] StrList = text.Split(" ");
                    foreach (var word in StrList)
                    {
                        list.Add(word);
                    }
                    break;
                case 11:
                    string text1 = "e u i a o";
                    string[] StrList1 = text1.Split(" ");
                    foreach (var words in StrList1)
                    {
                        list.Add(words);
                    }
                    list.SortList();
                    Console.WriteLine("\nAfter Sorting list :");
                    list.Display();
                    break;
                case 12:
                    list.Display();
                    break;
                case 13:
                    Console.WriteLine("\nEnter value u want to search");
                    string value = Console.ReadLine();
                    list.Search(value);
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}