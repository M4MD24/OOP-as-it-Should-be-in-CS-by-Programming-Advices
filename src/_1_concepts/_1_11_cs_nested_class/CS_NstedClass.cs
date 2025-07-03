using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_11_cs_nested_class;

class OuterClass {
    // Nested class
    public class InnerClass {
        public void display() {
            Console.WriteLine(
                "Message from Inner Class"
            );
        }
    }

    public void show() {
        Console.WriteLine(
            "Message from Outer Class"
        );
    }
}

class CS_NstedClass {
    static void main(
        string[] args
    ) {
        OuterClass outerClass = new OuterClass();
        outerClass.show();

        OuterClass.InnerClass innerClass = new OuterClass.InnerClass();
        innerClass.display();
    }
}