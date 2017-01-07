using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.MyCode
{
    /// <summary>
    /// A collection item
    /// </summary>
    class Pasto
    {
        private string _tipoDiPasto;

        // Constructor
        public Pasto(string TipoDiPasto)
        {
            this._tipoDiPasto = TipoDiPasto;
        }

        // Gets name
        public string TipoDiPasto
        {
            get { return _tipoDiPasto; }
        }
    }
}
