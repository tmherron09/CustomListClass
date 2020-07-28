# CustomList<T>.Remove(T) Method
### Definition
Namespace: _CustomListClass_

Removes the first T value matching object from the CustomList<T>.

| C# | |
|------| ----|
|  |public bool Remove (T value); |
#### Parameters
##### __value T__
The value of the matching object to remove from the instance of CustomList<T>.
##### Returns
__Boolean__
Return *true* if an __Item<T>__ with value successfully removed. Returns *false* if no object with matching value is found within __CustomList<T>__.
### Example

```csharp
using System;
using CustomListClass;

abstract public class Can
{
    protected double price;
    public string name;
    public double Price { get { return price; } protected set { this.price = value; } }
    public override bool Equals(object obj)
    {
        Can c = (Can)obj;
        if (name == c.name)
        {
            return true;
        }
        return false;
    }
    public override string ToString()
    {
        return name;
    }
}
public class Cola : Can
{
    public Cola()
    {
        name = "Cola";
        Price = .35;
    }
}
public class OrangeSoda : Can
{
    public OrangeSoda()
    {
        name = "Orange Soda";
        Price = .06;
    }
}
public class RootBeer : Can
{
    public RootBeer()
    {
        name = "Root Beer";
        Price = .60;
    }
}
public class Program
{
    public static void Main()
    {
        // Instaniate a new CustomList of Can with One of each soda.
        CustomList<Can> cans = new CustomList<Can>() { new Cola(), new RootBeer(), new OrangeSoda() };
        // Write to Console "There is Cola, Root Beer, Orange Soda."
        Console.WriteLine($"There is {cans.ToString()}.");

        // Create a new RootBeer instance.
        RootBeer rootBeer = new RootBeer();

        // Call the Remove() to remove the value matching RootBeer
        cans.Remove(rootBeer);

        // Write to Console the new list "There is Cola, Orange Soda."
        Console.WriteLine($"There is {cans.ToString()}.");

        if (!cans.Remove(rootBeer))
        {
            // If there is no RootBeer to remove, it will return false
            Console.WriteLine("No Root Beer in Custom List to remove.");
        }

        Console.ReadLine();

        /* Output:
         * "There is Cola, Root Beer, Orange Soda."
         * "There is Cola, Orange Soda."
         * "No Root Beer in Custom List to remove."
         */

    }
}
```