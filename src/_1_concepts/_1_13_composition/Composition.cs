using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_13_composition;

// Component class 1
class Engine {
    public void start() {
        Console.WriteLine(
            "Engine started."
        );
    }

    public void stop() {
        Console.WriteLine(
            "Engine stopped."
        );
    }
}

// Component class 2
class Transmission {
    public void shiftGear(
        int gear
    ) {
        Console.WriteLine(
            $"Shifted to gear {gear}."
        );
    }
}

// Composite class
class Car {
    private readonly Engine       engine;
    private readonly Transmission transmission;

    public Car() {
        engine       = new Engine();
        transmission = new Transmission();
    }

    public void startCar() {
        Console.WriteLine(
            "Starting the car..."
        );
        engine.start();
        transmission.shiftGear(
            1
        );
    }

    public void stopCar() {
        Console.WriteLine(
            "Stopping the car..."
        );
        engine.stop();
    }
}

// Program Entry
class Composition {
    static void Main(
        string[] args
    ) {
        Car car = new Car();
        car.startCar();

        Console.WriteLine(
            "Driving..."
        );

        car.stopCar();
    }
}