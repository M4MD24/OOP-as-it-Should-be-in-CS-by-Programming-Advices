using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_13_sealed._1_13_2_sealed_method;

class BaseClass {
    public virtual void display() {
        Console.WriteLine(
            "BaseClass Display"
        );
    }
}

class DerivedClass : BaseClass {
    public sealed override void display() {
        Console.WriteLine(
            "DerivedClass Display"
        );
    }
}

class MoreDerivedClass : DerivedClass {
    // This will cause a compile-time error because Display is sealed in DerivedClass.
    // public override void display() {
    //     Console.WriteLine(
    //         "MoreDerivedClass Display"
    //     );
    // }
}

class SealedMethod {
    static void Main() {
        BaseClass baseClass1 = new BaseClass();
        baseClass1.display();

        BaseClass baseClass2 = new DerivedClass();
        baseClass2.display();

        MoreDerivedClass moreDerivedClass = new MoreDerivedClass();
        moreDerivedClass.display(); // Would call DerivedClass Display since it's sealed
    }
}