# OOP as it should be in C#

**Important Note for Console App Projects:** To Run Any File Rename Main Method from "main" to "Main", Because can't run 2 Static "Main" Methods in One Project

1. [Concepts](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts)
    1. Introduction
    2. [Class & Object](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_2_class_and_object)
    3. Objects in Memory
    4. [Access Modifiers](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_4_access_modifiers)
    5. [Static Members](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_5_static_members)
    6. [Properties](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_6_properties)
        1. [Set and Get](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_6_properties/_1_6_1_set_and_get)
        2. [ReadOnly](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_6_properties/_1_6_2_readonly)
        3. Auto Implemented Properties
        4. [Static Properties & Static Class](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_6_properties/_1_6_4_static_properties_and_static_class)
    7. [Principles and Concepts of OOP (Object Oriented Programming)](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_7_principles_and_concepts_of_oop)
        1. Encapsulation
        2. Abstraction
        3. [Inheritance](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_7_principles_and_concepts_of_oop/_1_7_3_inheritance)
        4. [Inheritance Constructor](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_7_principles_and_concepts_of_oop/_1_7_4_inheritance_constructor)
        5. [Upcasting and Downcasting](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_7_principles_and_concepts_of_oop/_1_7_5_upcasting_and_downcasting)
        6. [Method Overriding in C# Inheritance and Base Keyword](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_7_principles_and_concepts_of_oop/_1_7_6_method_overriding_in_cs_inheritance_and_base_keyword)
        7. [Method Hiding in C#](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_7_principles_and_concepts_of_oop/_1_7_7_method_hiding_in_cs)
        8. Types Of Inheritance
        9. [Multiple-Level Inheritance](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_7_principles_and_concepts_of_oop/_1_7_9_multiple_level_inheritance)
        10. [Hierarchal Inheritance](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_7_principles_and_concepts_of_oop/_1_7_10_hierarchal_inheritance)
        11. Polymorphism
    8. [Constructor and Destructor](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_8_constructor_and_destructor)
        1. Constructor
        2. [Parameterless Constructor](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_8_constructor_and_destructor/_1_8_2_parameterless_constructor)
        3. [Parameterized Constructor](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_8_constructor_and_destructor/_1_8_3_parameterized_constructor)
        4. Default Constructor
        5. [Private Constructor vs Static Class](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_8_constructor_and_destructor/_1_8_5_private_constructor_vs_static_class)
        6. [Multiple Constructors using Overloading](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_8_constructor_and_destructor/_1_8_6_multiple_constructors_using_overlaoding)
        7. [Static Constructor](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_8_constructor_and_destructor/_1_8_7_static_constructor)
        8. [Destructor](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_8_constructor_and_destructor/_1_8_8_destructor)
        9. Real life Application of Using Static and Constructor
    9. [Abstract Class & Methods](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_9_abstract_class_and_methods)
    10. [Interface](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_10_interface)
        1. [What is Interface? and Why?](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_10_interface/_1_10_1_what_is_interface_and_why)
        2. [Implementing Multiple Interfaces](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_10_interface/_1_10_2_implementing_multiple_interfaces)
    11. [Nested Class](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_11_nested_class)
    12. [Composition](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_12_composition)
    13. [Sealed](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_13_sealed)
        1. [Sealed Class](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_13_sealed/_1_13_1_sealed_class)
        2. [Sealed Method](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_13_sealed/_1_13_2_sealed_method)
    14. [Partial](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_14_partial)
        1. [Partial Class](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_14_partial/_1_14_1_partial_class)
        2. [Partial Method](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_14_partial/_1_14_2_partial_method)
    15. [Introduction to Class Library](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_1_concepts/_1_15_introduction_to_class_library)
    16. Internal Access Modifier
    17. Class vs Struct
    18. Enums
2. [Projects](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_2_projects)
    1. [Calculator](OOP-as-it-should-be-in-CS-by-Programming-Advices/src/_2_projects/_2_1_calculator)