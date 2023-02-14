using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

public class Program
{
    static void Main(string[] args)
    {
        #region MyRegion
        Lion l = new Lion(7, false);
        Sparrow s = new Sparrow(7, false);
        Elephand e = new Elephand(7, true);
        Pigeon p = new Pigeon(7, false);
        Zoo zoo = new Zoo(); 
        zoo.Add(e);
        zoo.Add(l);
        zoo.Add(p);
        zoo.Add(s);  
        
        foreach (var item in zoo.animal)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------");
        foreach (var item in zoo.Birdss)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------");
        foreach (var item in zoo.mamles)
        {
            Console.WriteLine(item);
        }
        #endregion
        #region MyRegion
        //PhoneBook phonebook = new();
        //phonebook[123] = "Ali";
        //phonebook["Hossam"] = 456;
        //int phone = phonebook["Ali"];
        //foreach (var item in phonebook.entries)
        //{
        //    Console.WriteLine(item.Key);
        //}
        #endregion
    }

}
#region MyRegion
public class Zoo
{
    private List<Animals> birds = new List<Animals>();
    private List<Animals> mamels = new List<Animals>();

    public IReadOnlyCollection<Animals>? Birdss;
    public IReadOnlyCollection<Animals>? mamles;

    public List_animals animal= new List_animals();
    public void Add(Animals animals)
    {
        animal.Add(animals);
        birds.Add(animals as Birds);
        mamels.Add(animals as Mamels);
        Birdss = birds;
        mamles = mamels;
    }



}
public class Animals
{
    public Animals()
    {

    }
    public Animals(int age, bool is_die)
    {
        this.age = age;
        this.is_die = is_die;
    }

    public int age { get; set; }
    public bool is_die { get; set; }
}
public class List_animals : List<Animals>
{ 
    public new void  Add(Animals animals)
    {
        if (animals.age <= 10)
        {
           base.Add(animals);
            
        }
    }


}
public class Mamels : Animals
{
    public Mamels()
    {

    }
    public Mamels(int age, bool is_die) : base(age, is_die)
    {
    }
}
public class Birds : Animals
{
    public Birds()
    {

    }
    public Birds(int age, bool is_die) : base(age, is_die)
    {
    }
}
public class Lion : Mamels
{
    public Lion(int age, bool is_die) : base(age, is_die)
    {
    }
}
public class Sparrow : Birds
{
    public Sparrow(int age, bool is_die) : base(age, is_die)
    {
    }
}
public class Elephand : Mamels
{
    public Elephand(int age, bool is_die) : base(age, is_die)
    {
    }
}
public class Pigeon : Birds
{
    public Pigeon(int age, bool is_die) : base(age, is_die)
    {
    }
}
#endregion
public class PhoneBook
{
    public Dictionary<string, int> entries;


    PhoneBook(Dictionary<string, int> entries)
    {
        this.entries = entries;
    }

    public PhoneBook()
    {
        entries = new Dictionary<string, int>();
    }

    public int this[string key]
    {
        get { return entries[key]; }
        set { entries[key] = value; }
    }
    //return entries.FirstOrDefault(x => x.Value == key).Key;
    public string this[int key]
    {
        get
        {
            foreach (var entry in entries)
            {
                if (entry.Value == key)
                {
                     return entry.Key;
                }
            }
            return "";
        }
        set { entries[value] = key; }
    }
}