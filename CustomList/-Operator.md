# CustomList<T> - Operator Overload
### Definition
Namespace: _CustomListClass_

Defines __-__ Operator Overload for Subtraction of a subtrahend CustomList\<T\> T items from a minuend CustomList\<T\> T items.

| C# | |
|------| ----|
|  |public static CustomList\<T\> operator -(CustomList\<T\> minuend, CustomList\<T\> subtrahend); |
#### Parameters
##### __minuend__  _CustomList\<T\>_
The CustomList\<T\> from which we are subtracting from.
##### __subtrahend__  _CustomList\<T\>_
The CustomList\<T\> that is being subtracted from the minuend.
##### Returns
__CustomList\<T\>__
Returns the minuend minus the subtrahend in a new CustomList\<T\>.
The "-=" Operator may also be used. _(minuend -= subtrahend == minuend = minuend - subtrahend)_
### Example

```csharp
using System;
using CustomListClass;


public class Program
{
    public static void Main()
    {
        // Instaniate a new CustomList<int> 
        CustomList<int> minuend = new CustomList<int>() { 1, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        //  Instantiate our first subtrahend
        CustomList<int> subtrahend = new CustomList<int>() { 4, 5, 6 };
        
        // Use the - Operator to perform the subtraction.
        minuend = minuend - subtrahend;
        
        Console.WriteLine(minuend);
        /* Writes to Console
        * "1, 1, 1, 2, 3, 7, 8, 9, 10"
        */

        // Instantiate a second subtrahend.
        CustomList<int> secondSubtrahend = new CustomList<int>() { 11, 10, 9 };

        // Use the - Operator to perform the subtraction.
        minuend = minuend - subtrahend;
        
        Console.WriteLine(minuend);
        /* Writes to Console
        * "1, 1, 1, 2, 3, 7, 8"
        * The 11 in the secondSubtrahend is ignored as it was not present in the minuend.
        */
        
        // Instantiate a third subtrahend.
        CustomList<int> thirdSubtrahend = new CustomList<int>() { 1 };

        // Use the - Operator to perform the subtraction.
        minuend = minuend - subtrahend;
        
        Console.WriteLine(minuend);
        /* Writes to Console
        * "1, 1, 2, 3, 7, 8"
        * The 1 in the thirdSubtrahend is only subtracted once.
        */
        
        // Finally we can use the "-=" Operator in the same manor as - operator to subtract the minuend from itself.
        minuend -= minued;
        
        Console.WriteLine(minuend);
        /* Writes to Console
        * "Empty Custom List"
        * We are left with an Empty Custom List.
        */
    }
}
```
## Remarks
All matching values from subtrahend contained in the minuend will be removed. 
Values in the subtrahend will only be subtracted once. The subtrahend will not cause negative values.
