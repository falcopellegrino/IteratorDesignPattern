﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structural = IteratorDesignPattern.StructuralCode;
//using Real = IteratorDesignPattern.RealWorldCode;
//using My = IteratorDesignPattern.MyCode;

namespace IteratorDesignPattern
{
    // Iterator

    // Definition
    // Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

    // Participants
    // The classes and objects participating in this pattern are:
    //  - Iterator (AbstractIterator)
    //      --> defines an interface for accessing and traversing elements.
    //  - ConcreteIterator (Iterator)
    //      --> implements the Iterator interface.
    //      --> keeps track of the current position in the traversal of the aggregate.
    //  - Aggregate (AbstractCollection)
    //      --> defines an interface for creating an Iterator object
    //  - ConcreteAggregate (Collection)
    //      --> implements the Iterator creation interface to return an instance of the proper ConcreteIterator

    /// <summary>
    /// MainApp startup class for Structural 
    /// Iterator Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the Iterator pattern which provides for a way to traverse (iterate)
            // over a collection of items without detailing the underlying structure of the collection.
            Structural.ConcreteAggregate a = new Structural.ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // Create iterator and provide aggregate
            Structural.Iterator i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            object item = i.First();
            while(item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            // Wait for user
            Console.ReadKey();
            #endregion

            #region Real world code in C#
            // Real-world code in C#
            // This real-world code demonstrates the Iterator pattern which is used to iterate over a collection of items
            // and skip a specific number of items each iteration. 
            #endregion

            #region My code in C#
            #endregion
        }
    }
}







