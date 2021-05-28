using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverBear.WebMVC.Utils
{
    public class ParentChild : Parent
    {
        public override void Foo()
        {
            Console.WriteLine("Now Child Foo");
        }

        public new void Bar()
        {
            Console.WriteLine("Now Child Bar");
        }
    }

    public class Parent
    {
        public virtual void Foo() {
            Console.WriteLine("Now Parent Foo");
        }
        public void Bar() { 
            Console.WriteLine("Now Parent Bar");
        }
    }
}
