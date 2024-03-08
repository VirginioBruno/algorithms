using algorithms.console.Insertion;
using algorithms.console.Search.Binary;
using algorithms.console.Search.Linear;

Console.WriteLine("Algorithms Project");


Console.WriteLine("------------- Insertion Algorithms -------------");

Insertion.DoInsertionAtPosition();
Insertion.DoInsertionAtStart();
Insertion.DoInsertionAtEnd();


Console.WriteLine("------------- Search Algorithms -------------");

LinearSearch.Do();
BinarySearch.Do();
BinarySearch.DoRecursive();


