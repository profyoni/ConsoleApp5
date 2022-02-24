using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLib.Test2;

[TestClass]
public class PolyTest
{


    [TestMethod]
    public void test1()
    {
        Base b = new Base();
        b.Act("").Should().Be("Base");


        Derived d = new Derived();
        d.Act("").Should().Be("Derived");
        d.Foo();
        d.ActI("").Should().Be("Base:ActI");

        b = d;
        b.Act("").Should().Be("Base"); 

    }


    [TestMethod]
    public void test2()
    {
        BasePoly b = new BasePoly();
        b.Act("").Should().Be("Base");


        DerivedPoly d = new DerivedPoly();
        d.Act("").Should().Be("Derived");
        d.Foo();

        b = d;
        b.Act("").Should().Be("Derived");

        Console.WriteLine(new Fraction());
    }
}