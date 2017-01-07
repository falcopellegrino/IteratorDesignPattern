using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.MyCode
{
    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    interface IAbstractCollectionOfMeals
    {
        IteratorOfMeals CreateIteratorOfMeals();
    }
}
