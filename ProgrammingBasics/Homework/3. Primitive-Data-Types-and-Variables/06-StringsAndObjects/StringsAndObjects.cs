using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string hello = "Hello";
        string world = "World";
        object container = hello + " " + world;
        string helloWorld = (string)container;
        Console.WriteLine(helloWorld);
    }
}

