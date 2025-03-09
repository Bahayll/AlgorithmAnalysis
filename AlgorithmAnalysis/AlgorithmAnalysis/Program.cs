// See https://aka.ms/new-console-template for more information
using AlgorithmAnalysis.BubbleSortAlgorithm;
using AlgorithmAnalysis.Tester;



int[] sizeArray = { 10, 100, 1000, 5000 };

SortingAlgorithmTester.TestSortAlgorithm(BubleSort.Sort, sizeArray);

SortingAlgorithmTester.TestSortAlgorithm(BubleSort.OptimizedSort, sizeArray);
