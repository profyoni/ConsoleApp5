using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Base
    {
        public String Act(String s)
        {
            return "Base" + s;
        }
        public String ActI(String s)
        {
            return "Base:ActI" + s;
        }

        public virtual String ActIII(String s)
        {
            return "Base:ActI" + s;
        }
    }

    public class Derived: Base
    {
        private String  Act(String s)
        {
            return "Derived" + s;
        }

        public void Foo()
        {

        }

        public override String ActIII(String s)
        {
            return "Base:ActI" + s;
        }
    }
}

public class BasePoly
{
    public virtual String Act(String s)
    {
        return "Base" + s;
    }
}

public class DerivedPoly : BasePoly
{
    public override String Act(String s)
    {
        return "Derived" + s;
    }

    public void Foo()
    {

    }
}
