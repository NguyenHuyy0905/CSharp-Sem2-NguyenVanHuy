using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Tạo một hàng đợi
        Queue myQueue = new Queue();

        // Thêm phần tử vào hàng đợi
        myQueue.Enqueue("Element 1");
        myQueue.Enqueue("Element 2");
        myQueue.Enqueue("Element 3");

        // In ra các phần tử trong hàng đợi
        Console.WriteLine("Queue elements:");
        foreach (var element in myQueue)
        {
            Console.WriteLine(element);
        }

        // Lấy và xóa phần tử từ đầu hàng đợi
        object dequeuedElement = myQueue.Dequeue();
        Console.WriteLine("\nDequeued element: " + dequeuedElement);

        // In ra lại các phần tử còn lại trong hàng đợi
        Console.WriteLine("\nRemaining elements in the queue:");
        foreach (var element in myQueue)
        {
            Console.WriteLine(element);
        }

        // -------------------------------------------

        // Tạo một ngăn xếp
        Stack myStack = new Stack();

        // Thêm phần tử vào ngăn xếp
        myStack.Push("Element 1");
        myStack.Push("Element 2");
        myStack.Push("Element 3");

        // In ra các phần tử trong ngăn xếp
        Console.WriteLine("Stack elements:");
        foreach (var element in myStack)
        {
            Console.WriteLine(element);
        }

        // Lấy và xóa phần tử từ đỉnh ngăn xếp
        object poppedElement = myStack.Pop();
        Console.WriteLine("\nPopped element: " + poppedElement);

        // In ra lại các phần tử còn lại trong ngăn xếp
        Console.WriteLine("\nRemaining elements in the stack:");
        foreach (var element in myStack)
        {
            Console.WriteLine(element);
        }

        // -------------------------------------------

        // Tạo một Hashtable
        Hashtable myHashtable = new Hashtable();

        // Thêm các cặp key-value vào Hashtable
        myHashtable.Add("key1", "value1");
        myHashtable.Add("key2", "value2");
        myHashtable.Add("key3", "value3");

        // Truy cập giá trị bằng key
        string valueForKey2 = (string)myHashtable["key2"];
        Console.WriteLine("Value for key 'key2': " + valueForKey2);

        // -------------------------------------------
        
        // Tạo một SortedList
        SortedList mySortedList = new SortedList();

        // Thêm các cặp key-value vào SortedList
        mySortedList.Add("key3", "value3");
        mySortedList.Add("key1", "value1");
        mySortedList.Add("key2", "value2");

        // Truy cập giá trị bằng key
        string valueForKey1 = (string)mySortedList["key1"];
        Console.WriteLine("Value for key 'key1': " + valueForKey1);

        // Duyệt qua các phần tử trong SortedList
        Console.WriteLine("\nSorted List elements:");
        foreach (DictionaryEntry entry in mySortedList)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }        
}
