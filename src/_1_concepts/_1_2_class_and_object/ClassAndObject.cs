namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_2_class_and_object;

internal class ClassAndObject {
    // Class
    private class Person {
        // Fields
        public string firstName,
                      secondName;

        // Methods
        public string getFullName() {
            return$"{firstName} {secondName}";
        }
    }

    public static void main(
        string[] args
    ) {
        Person firstPerson = new Person();
        firstPerson.firstName  = "Mohamed";
        firstPerson.secondName = "Sadawy";
        Console.WriteLine(
            $"Full Name of First Person: {firstPerson.getFullName()}"
        );

        Person secondPerson = new Person();
        secondPerson.firstName  = "Ahmed";
        secondPerson.secondName = firstPerson.secondName;
        Console.Write(
            $"Full Name of First Person: {secondPerson.getFullName()}"
        );
    }
}