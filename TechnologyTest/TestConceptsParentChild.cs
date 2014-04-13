using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyTest
{
    class Parent
    {
        public void parentMethod()
        {
            System.Console.WriteLine("Parent.parentMethod");
        }
        public virtual void  parentVirtualMethod()
        {
            System.Console.WriteLine("Parent.parentVirtualMethod");
        }

    }
    class Child  : Parent
    {
        public void parentMethod()
        {
            System.Console.WriteLine("Child.parentMethod");
        }
        public override void parentVirtualMethod()
        {
            System.Console.WriteLine("Child.parentVirtualMethod");
        }
    }
    class TestVirtualAndOverride{
        public void controller()
        {
            Parent childRef = new Child();
            //although parent object (childRef) is referncing to child object.. parent's method is called unlike in java 
            //as the parentMethod is not virtual
            childRef.parentMethod(); //output: Parent.parentMethod
            //as parent object (childRef) is referncing to child object.. Child's method is called as in java.. (in java all methods are virtual by default)
            //as the parentVirtualMethod  is marked virtual in base class and is marked for overriden in the derived class
            childRef.parentVirtualMethod(); //output : Child.parentVirtualMethod
            

        }
    }
}
