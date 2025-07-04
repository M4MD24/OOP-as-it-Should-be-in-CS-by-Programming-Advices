using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_6_method_overriding_in_cs_inheritance_and_base_keyword;

public static class MethodOverridingInCS_InheritanceAndBaseKeyword {
    public class FirstClass {
        public virtual void print() {
            Console.Write(
                "First Class"
            );
        }
    }

    public class SecondClass : FirstClass {
        public override void print() {
            base.print();
            Console.Write(
                ", Second Class"
            );
        }
    }

    public static void main(
        string[] args
    ) {
        new FirstClass().print();
        Console.WriteLine();
        new SecondClass().print();
    }
}