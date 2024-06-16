// See https://aka.ms/new-console-template for more information
using Custom_Double_Linked_List;

var testlista = new int[20]; 

var testlista1 = new int[3];

var test = new CustomLinkedList<int>();

test.AddToEnd(1);

test.AddToEnd(2);

test.AddToEnd(3);

test.Add(1);

test.Add(2);

test.Remove(1);

bool testVlaue1 = test.Contains(1);

bool testVlaue2 = test.Contains(10);

test.CopyTo(testlista, 2);


Console.WriteLine("test's passed");

test.CopyTo(testlista1, 2);

Console.WriteLine("Hello, World!");
