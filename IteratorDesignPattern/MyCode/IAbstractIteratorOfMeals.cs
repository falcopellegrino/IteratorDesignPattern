using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.MyCode
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    interface IAbstractIteratorOfMeals
    {
        Pasto First();
        Pasto Next();
        bool IsDone { get; }
        Pasto CurrentMeal { get; }
    }
}
