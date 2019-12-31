using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackBoxComposition
{
    interface IFruit
    {
        int Color { get; set; }
    }

    interface IPeelable
    {
        void peel();
    }

    class Fruit : IFruit, IPeelable
    {
        public int Color { get; set; }

        public void peel()
        {
        }
    }

    class Orange : IPeelable
    {
        public Fruit fruit { get; set; }

        public void squeeze()
        {
        }

        public void peel()
        {
            fruit.peel();
            //... + mio peel code ... v
        }

    }
}
