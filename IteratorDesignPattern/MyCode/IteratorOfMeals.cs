using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.MyCode
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class IteratorOfMeals : IAbstractIteratorOfMeals
    {
        private CollectionOfMeals _collectionOfMeals;
        private int _currentMeal = 0;
        private int _step = 1;

        // Constructor
        public IteratorOfMeals(CollectionOfMeals collectionOfMeals)
        {
            this._collectionOfMeals = collectionOfMeals;
        }

        // Gets first item
        public Pasto First()
        {
            _currentMeal = 0;
            return _collectionOfMeals[_currentMeal] as Pasto;
        }

        // Gets next item
        public Pasto Next()
        {
            _currentMeal += _step;
            if (!IsDone)
            {
                return _collectionOfMeals[_currentMeal] as Pasto;
            }
            else
            {
                return null;
            }
        }

        // Gets or sets stepsize
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        // Gets current iterator item
        public Pasto CurrentMeal
        {
            get { return _collectionOfMeals[_currentMeal] as Pasto; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return _currentMeal >= _collectionOfMeals.Count; }
        }
    }
}
