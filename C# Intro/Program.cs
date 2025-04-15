using C__Intro;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ShowNumericTypes();
        ShowFlowControls();
        ShowBooleanTypes();
        ShowCollectionTypes();
        ShowQueueAndStack();
        ShowObjects();
        ShowEnum();

        var myCar = new SedanCar();
    }

    private static void ShowNumericTypes()
    {
        //Numeric types
        var myInteger = 100;
        var myNegativeInteger = -500;

        var myHugeNumber = 1_000_236;

        var myFloatNumber = 23F;

        var myDouble = 3.14;

        //Char/strings

        var myChar = 'A';

        var myString = "Hello, World!";

        var amITrue = false;
    }

    private static void ShowFlowControls()
    {
        //Flow control
        var myNumber = 10;

        if (myNumber > 5)
        {
            Console.WriteLine("The number is greater than 5");
        }
        else
        {
            Console.WriteLine("The number is less than 5");
        }

        switch (myNumber)
        {
            case 1:
                Console.WriteLine("The number is 1");
                break;
            case 2:
                Console.WriteLine("The number is 2");
                break;
            default:
                Console.WriteLine("The number is not 1 or 2");
                break;
        }

        int[] array2 = [1, 2, 3, 4, 5];
        for (var i = 0; i < 10; i++)
        {
            var value = array2[i];
            Console.WriteLine(i);
        }

        int[] array = [1, 2, 3, 4, 5];
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        var j = 0;
        while (j < 10)
        {
            Console.WriteLine(j);
            j++;
        }

        do
        {
            Console.WriteLine(j);
            j++;
        } while (j < 10);
    }
    
    private static void ShowBooleanTypes()
    {
        //Boolean types
        var amITrue = true;
        var amIFalse = false;
    }

    private static void ShowCollectionTypes()
    {
        //Collections
        var myArray = new int[5];
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;
        myArray[3] = 4;
        myArray[4] = 5;

        myArray.Append(6);
        myArray.Count();
        Array.Sort(myArray);

        var myList = new List<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);

        myList.Add(6);
        myList.Remove(3);
        myList.Remove(4);
        myList.Count();
        myList.Sort();

        var tuple = (12, "a");
        

        var myDictionary = new Dictionary<string, int[]>();
        myDictionary.Add("One", [1,2]);
        myDictionary.Add("Two", [2]);
        myDictionary.Add("Three", [3]);
        myDictionary.Add("Four", [4]);
        myDictionary.Add("Five", [5]);
    }

    private static void ShowQueueAndStack()
    {
        //Queue and Stack
        var myQueue = new Queue<int>();
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);
        myQueue.Enqueue(4);
        myQueue.Enqueue(5);

        var myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);
    }

    private static void ShowObjects()
    {
        //Objects
        var myObject = new object();
        myObject.Equals(new object());

        var myObject2 = new
        {
            Color = "red",
            Value = 2,
            Name = "MyObject"
        };
        var x=myObject2.Color;
    }

    enum Level { Low, Medium, High }

    private static void ShowEnum()
    {
        var enum1 = Level.Low;
        var enum2 = Level.Medium;
        var enum3 = Level.High;
    }

    private static void ShowMethods()
    {
        //Methods
        var myNumber = 10;
        var myNumber2 = 20;

        var result = Add(myNumber, myNumber2);
        Console.WriteLine(result);
    }

    private static int Add(int a, int b)
    {
        return a + b;
    }
}