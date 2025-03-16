// See https://aka.ms/new-console-template for more information
using AlgorithmAnalysis.FinderAlgorithms;
using AlgorithmAnalysis.SortAlgorithms;
using AlgorithmAnalysis.Tester;



// int[] sizeArray = { 10, 100, 1000, 5000 };
int[] sizeArray = { 10, 100 };
/*
SortingAlgorithmTester.TestSortAlgorithm(BubleSort.Sort, sizeArray);

SortingAlgorithmTester.TestSortAlgorithm(BubleSort.OptimizedSort, sizeArray);
*/
/*
SortingAlgorithmTester.TestSortAlgorithm(InsertionSort.SortAscending, sizeArray);
SortingAlgorithmTester.TestSortAlgorithm(InsertionSort.SortDescending, sizeArray);
SortingAlgorithmTester.TestSortAlgorithm(InsertionSort.OptimizedSort, sizeArray);
*/
KthSmallestTester.TestKthSmallestAlgorithm(KthSmallestFinder.FindKthSmallest_Sort, sizeArray, 10);
KthSmallestTester.TestKthSmallestAlgorithm(KthSmallestFinder.FindKthSmallest_Insertion, sizeArray, 5);
