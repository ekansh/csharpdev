using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyTest
{
    /**
     * Deomnstrate the abstract classes, interfaces and usage of readonly and const keyword
     */ 
    public abstract class AnAbstractClassEmployee
    {
        
        private string name;
        private string position;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// get and set 
        /// </summary>
        public string Position
        {
            get;
            set;
        }

        public abstract String calculateEligibilityForPerks();


      
    }

    public interface AnInterfaceUnknown
    {
          string aMethod(string arg);
    }
    public class AConcreteClassManager : AnAbstractClassEmployee,AnInterfaceUnknown
    {

    
        public  string aMethod(string arg)
        {
            System.Console.WriteLine("AConcreteClassManager.aMethod for name {0}, poistion {1}",Name,Position);
            return "aMethod";
        }

        public  override string calculateEligibilityForPerks()
        {
            System.Console.WriteLine("AConcreteClassManager.calculateEligibilityForPerks for name {0}, poistion {1}",Name,Position);
            return "calculateEligibilityForPerks";
        }
    }

    class TestAbstractionAndInterface
    {
        public void controller()
        {

            System.Console.WriteLine("=============Abstract class object pointing to concrete class=============");
            AnAbstractClassEmployee anEmp = new AConcreteClassManager();

            anEmp.Name = "firstname";
            anEmp.Position = "manager";
            anEmp.calculateEligibilityForPerks();
            System.Console.WriteLine("emppoyee Name {0}, employee position {1}", anEmp.Name,anEmp.Position);
           
            System.Console.WriteLine("=============Interface  object pointing to concrete class=============");
            AnInterfaceUnknown anotherEmp = new AConcreteClassManager();
            anotherEmp.aMethod(null);
            
        }
    }
}
