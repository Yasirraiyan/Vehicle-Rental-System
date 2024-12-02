class program
{
    public static void Main(string[] args)
    {
        Vehicle v1 = new Vehicle(1, "Pickup", false, 100, false, 100, 0, 0, 0);
        Vehicle v2 = new Vehicle(2, "Car", true, 1000, true, 50, 1, 0, 0);
        Vehicle v3 = new Vehicle(3, "Cng", false, 500, true, 40, 1, 1, 0);
        Vehicle v4 = new Vehicle(4, "Van", true, 10, true, 60, 0, 1, 0);
        Vehicle v5 = new Vehicle(5, "Launch", false, 1, false, 70, -1, 1, 0);
        Vehicle v6 = new Vehicle(6, "Boat", true, 15, true, 80, -1, 0, 0);
        Vehicle v7 = new Vehicle(7, "Truck", false, 2000, false, 30, -1, -1, 0);
        Vehicle v8 = new Vehicle(8, "Cab", true, 800, true, 20, 0, -1, 0);
        Vehicle v9 = new Vehicle(9, "Bus", false, 5000, false, 10, 1, -1, 0);

        List<Vehicle> vehicles = new List<Vehicle> { v1, v2, v3, v4, v5, v6, v7, v8, v9 };

        foreach (var v in vehicles)
        {
            Console.WriteLine(v.checkavailibily(v.availability, v.name));
            v.getid(v.name);
            v.getcapacity(v.name);
            v.rent(v.id, 30, v.availability);
            v.showinfo(v.id, v.name, v.availability, v.fee, v.capacity);
            v.remove(v.id, v.availability, v.name);
            v.getcondition(v.availability, v.life, v.attack);
            v.getposition2dcooordinatesystem(v.x, v.y);
            v.getposition3dcooordinatesystem(v.x, v.y, v.z);
            v.getname();
            v.getfee(v.id);
            v.getdamage(v.attack, v.life);
        }
        Console.WriteLine(v1.checkavailibily(v1.availability, v1.name));
        v1.getid(v1.name);
        v1.getcapacity(v1.name);
        v1.rent(v1.id, 30, v1.availability);
        v1.showinfo(v1.id, v1.name, v1.availability, v1.fee, v1.capacity);
        v1.remove(v1.id, v1.availability, v1.name);
        v1.getcondition(v1.availability, v1.life, v1.attack);
        v1.getposition2dcooordinatesystem(v1.x, v1.y);
        v1.getposition3dcooordinatesystem(v1.x, v1.y, v1.z);
        v1.getname();
        v1.getfee(v1.id);
        v1.getdamage(v1.attack, v1.life);
        Console.WriteLine(v2.checkavailibily(v2.availability, v2.name));
        v2.getid(v2.name);
        v2.getcapacity(v2.name);
        v2.rent(v2.id, 30, v2.availability);
        v2.showinfo(v2.id, v2.name, v2.availability, v2.fee, v2.capacity);
        v2.remove(v2.id, v2.availability, v2.name);
        v2.getcondition(v2.availability, v2.life, v2.attack);
        v2.getposition2dcooordinatesystem(v2.x, v2.y);
        v2.getposition3dcooordinatesystem(v2.x, v2.y, v2.z);
        v2.getname();
        v2.getfee(v2.id);
        v2.getdamage(v2.attack, v2.life);
        Console.WriteLine(v3.checkavailibily(v3.availability, v3.name));
        v3.getid(v3.name);
        v3.getcapacity(v3.name);
        v3.rent(v3.id, 30, v3.availability);
        v3.showinfo(v3.id, v3.name, v3.availability, v3.fee, v3.capacity);
        v3.remove(v3.id, v3.availability, v3.name);
        v3.getcondition(v3.availability, v3.life, v3.attack);
        v3.getposition2dcooordinatesystem(v3.x, v3.y);
        v3.getposition3dcooordinatesystem(v3.x, v3.y, v3.z);
        v3.getname();
        v3.getfee(v3.id);
        v3.getdamage(v3.attack, v3.life);
        Console.WriteLine(v4.checkavailibily(v4.availability, v4.name));
        v4.getid(v4.name);
        v4.getcapacity(v4.name);
        v4.rent(v4.id, 30, v4.availability);
        v4.showinfo(v4.id, v4.name, v4.availability, v4.fee, v4.capacity);
        v4.remove(v4.id, v4.availability, v4.name);
        v4.getcondition(v4.availability,v4.life, v4.attack);
        v4.getposition2dcooordinatesystem(v4.x, v4.y);
        v4.getposition3dcooordinatesystem(v4.x, v4.y, v4.z);
        v4.getname();
        v4.getfee(v4.id);
        v4.getdamage(v4.attack, v4.life);
        Console.WriteLine(v5.checkavailibily(v5.availability, v5.name));
        v5.getid(v5.name);
        v5.getcapacity(v5.name);
        v5.rent(v5.id, 30, v5.availability);
        v5.showinfo(v5.id, v5.name, v5.availability, v5.fee, v5.capacity);
        v5.remove(v5.id, v5.availability, v5.name);
        v5.getcondition(v5.availability, v5.life, v5.attack);
        v5.getposition2dcooordinatesystem(v5.x, v5.y);
        v5.getposition3dcooordinatesystem(v5.x, v5.y, v5.z);
        v5.getname();
        v5.getfee(v5.id);
        v5.getdamage(v5.attack, v5.life);
        Console.WriteLine(v6.checkavailibily(v6.availability, v6.name));
        v6.getid(v6.name);
        v6.getcapacity(v6.name);
        v6.rent(v6.id, 30, v6.availability);
        v6.showinfo(v6.id, v6.name, v6.availability, v6.fee, v6.capacity);
        v6.remove(v6.id, v6.availability, v6.name);
        v6.getcondition(v6.availability, v6.life, v6.attack);
        v6.getposition2dcooordinatesystem(v6.x, v6.y);
        v6.getposition3dcooordinatesystem(v6.x, v6.y, v6.z);
        v6.getname();
        v6.getfee(v6.id);
        v6.getdamage(v6.attack, v6.life);
        Console.WriteLine(v7.checkavailibily(v7.availability, v7.name));
        v7.getid(v7.name);
        v7.getcapacity(v7.name);
        v7.rent(v7.id, 30, v7.availability);
        v7.showinfo(v7.id, v7.name, v7.availability, v7.fee, v7.capacity);
        v7.remove(v7.id, v7.availability, v7.name);
        v7.getcondition(v7.availability, v7.life, v7.attack);
        v7.getposition2dcooordinatesystem(v7.x, v7.y);
        v7.getposition3dcooordinatesystem(v7.x, v7.y, v7.z);
        v7.getname();
        v7.getfee(v7.id);
        v7.getdamage(v7.attack, v7.life);
        Console.WriteLine(v8.checkavailibily(v8.availability, v8.name));
        v8.getid(v8.name);
        v8.getcapacity(v8.name);
        v8.rent(v8.id, 30, v8.availability);
        v8.showinfo(v8.id, v8.name, v8.availability, v8.fee, v8.capacity);
        v8.remove(v8.id, v8.availability, v8.name);
        v8.getcondition(v8.availability, v8.life, v8.attack);
        v8.getposition2dcooordinatesystem(v8.x, v8.y);
        v8.getposition3dcooordinatesystem(v8.x, v8.y, v8.z);
        v8.getname();
        v8.getfee(v8.id);
        v8.getdamage(v8.attack, v8.life);
        Console.WriteLine(v9.checkavailibily(v9.availability, v9.name));
        v9.getid(v9.name);
        v9.getcapacity(v9.name);
        v9.rent(v9.id, 30, v9.availability);
        v9.showinfo(v9.id, v9.name, v9.availability, v9.fee, v9.capacity);
        v9.remove(v9.id, v9.availability, v9.name);
        v9.getcondition(v9.availability, v9.life, v9.attack);
        v9.getposition2dcooordinatesystem(v9.x, v9.y);
        v9.getposition3dcooordinatesystem(v9.x, v9.y, v9.z);
        v9.getname();
        v9.getfee(v9.id);
        v9.getdamage(v9.attack, v9.life);
        Vehicle vehicle = new Vehicle(1, "Pickup", false, 100, false, 100, 0, 0, 0); 
        Car[] cars = 
            { 
            new Car(500, 4, vehicle, false, 0, 0, 0, false), 
            new Car(600, 5, vehicle, true, 1, 0, 0, true),
            new Car(700, 6, vehicle, false, 1, 1, 0, false), 
            new Car(800, 7, vehicle, true, 0, 1, 0, true), 
            new Car(900, 8, vehicle, false, -1, 1, 0, false), 
            new Car(1000, 9, vehicle, true, -1, 0, 0, true), 
            new Car(1100, 10, vehicle, false, -1, -1, 0, false), 
            new Car(1200, 11, vehicle, true, 0, -1, 0, true), 
            new Car(1300, 12, vehicle, false, 1, -1, 0, false), 
            new Car(1400, 13, vehicle, true, 2, 2, 0, true) 
        }; 
        foreach (var car in cars) 
        { 
            Console.WriteLine(car.checkcar(car.load, car.seat, car.availability)); 
            Console.WriteLine("Load: " + car.getload(car.load)); 
            Console.WriteLine("Seat: " + car.getseat(car.seat)); 
            Console.WriteLine("Fare: " + car.calculatefare(car.seat)); 
            car.getposition2dcooordinatesystem(car.x, car.y);
            car.getposition3dcooordinatesystem(car.x, car.y, car.z); 
           car.getdamage(car.attack, car.vehicle.life); 
        }
        Vehicle vehicle2 = new Vehicle(1, "Pickup", false, 100, false, 100, 0, 0, 0); 
        Pickup[] pickups = 
            { 
            new Pickup(1000, 2, vehicle, false, 0, 0, 0, false), 
            new Pickup(2000, 3, vehicle, true, 1, 0, 0, true),
            new Pickup(3000, 4, vehicle, false, 1, 1, 0, false), 
            new Pickup(4000, 5, vehicle, true, 0, 1, 0, true), 
            new Pickup(5000, 6, vehicle, false, -1, 1, 0, false), 
            new Pickup(6000, 7, vehicle, true, -1, 0, 0, true), 
            new Pickup(7000, 8, vehicle, false, -1, -1, 0, false), 
            new Pickup(8000, 9, vehicle, true, 0, -1, 0, true), 
            new Pickup(9000, 10, vehicle, false, 1, -1, 0, false),
            new Pickup(10000, 11, vehicle, true, 2, 2, 0, true) 
        }; 
        foreach (var pickup in pickups) 
        {
            Console.WriteLine(pickup.checkpickup(pickup.load, pickup.seat, pickup.availability)); 
            Console.WriteLine("Load: " + pickup.getload(pickup.load)); 
            Console.WriteLine("Seat: " + pickup.getseat(pickup.seat)); 
            Console.WriteLine("Fare: " + pickup.calculatefare(pickup.seat)); 
            pickup.getposition2dcooordinatesystem(pickup.x, pickup.y); 
            pickup.getposition3dcooordinatesystem(pickup.x, pickup.y, pickup.z); 
            pickup.getdamage(pickup.attack, pickup.vehicle.life); 
        }
    }
}
