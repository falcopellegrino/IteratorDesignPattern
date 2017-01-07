using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.MyCode
{
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    class CollectionOfMeals : IAbstractCollectionOfMeals
    {
        private ArrayList _pasti = new ArrayList();

        public IteratorOfMeals CreateIteratorOfMeals()
        {
            return new IteratorOfMeals(this);
        }

        // Gets item count
        public int Count
        {
            get { return _pasti.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _pasti[index]; }
            set { _pasti.Add(value); }
        }
    }
}
