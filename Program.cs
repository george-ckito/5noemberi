using _5noemberi.Dictionary;
using _5noemberi.Quene;
using _5noemberi.Stack;
while(true)
{
    Console.WriteLine("//// Dictionary ////");
    Console.WriteLine("1. Dictionary Avarage");
    Console.WriteLine("2. Class Students");
    Console.WriteLine("//// Stack ////");
    Console.WriteLine("3. Remove Element");
    Console.WriteLine("4. Reverse String");
    Console.WriteLine("5. First Three Element Sum");
    Console.WriteLine("//// Queue ////");
    Console.WriteLine("6. First Three Element Sum");
    Console.Write("Choose a program to run: ");
    char input = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch (input)
    {
        case '1':
            DictionaryAvarage dictionaryAvarage = new DictionaryAvarage();
            dictionaryAvarage.Execute();
            break;
        case '2':
            CLassStudents cLassStudents = new CLassStudents();
            cLassStudents.Execute();
            break;
        case '3':
            RemoveElement removeElement = new RemoveElement();
            removeElement.Execute();
            break;
        case '4':
            ReverseString reverseString = new ReverseString();
            reverseString.Execute();
            break;
        case '5':
            ThreeSum threeSum = new ThreeSum();
            threeSum.Execute();
            break;
        case '6':
            Sum sum = new Sum();
            sum.Execute();
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
    Console.Clear();
}