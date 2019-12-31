using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    class Fruit
    {
        public virtual int Color { get; set; }
        public virtual void peel()
        {
        }
    }

    class Orange : Fruit
    {
        public void squeeze()
        {
        }

        public override void peel()
        {
            base.peel();
            //+ .. mio peel code
        }
    }
}
