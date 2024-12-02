    public class Vehicle
    {
        public int id;
        public string name;
        public bool availability = false;
        public double fee;
        public List<Vehicle> vehicle = new List<Vehicle>() { };
        public int capacity;
        public bool attack = false;
        public int life;
        public int x;
        public int y;
        public int z;
        public Vehicle(int id, string name, bool availability, double fee, bool attack, int life, int x, int y, int z)
        {
            this.id = id;
            this.name = name;
            this.availability = availability;
            this.fee = fee;
            this.attack = attack;
            this.life = life;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public (bool, string) checkavailibily(bool availability, string name)
        {
            if (!availability && (name == "Car" || name == "Pickup"))
            {
                Console.WriteLine("Vehicle is available");
            }
            else
            {
                Console.WriteLine("Vehicle unavailable");
            }
            return (availability, name);

        }
        public void getid(string name)
        {
            if (name == "Pickup")
            {
                Console.WriteLine("Vahicle id is 1");
            }
            if (name == "Car")
            {
                Console.WriteLine("Vahicle id is 2");
            }
        }
        public void getcapacity(string name)
        {
            if (name == "Pickup")
            {
                Console.WriteLine("Pickup capacity is 1000");
            }
            if (name == "Car")
            {
                Console.WriteLine("Pickup capacity is 50");
            }
        }
        public void rent(int id, int days, bool availablity)
        {
            if (id == 1 && days <= 10 && !availability)
            {
                Console.WriteLine("Pickup booked.Rent is 10000.");
                vehicle.Add(new Vehicle(id, name, availability, fee, attack, life, 0, 0,0));
            }
            if (id == 2 && days <= 30 && !availability)
            {
                Console.WriteLine($"Car booked.Rent is {5000 * days}.");
                vehicle.Add(new Vehicle(id, name, availability, fee, attack, life, 0, 0, 0));
            }
        }
        public void showinfo(int id, string name, bool availability, double fee, int capacity)
        {
            foreach (var vehicle in vehicle)
            {
                Console.WriteLine($"Rental vehicles info: Id is: {id}, Name is: {name}, Availability is: {availability}, Fee is: {fee}, Capacity is: {capacity}");
            }
        }
        public void remove(int id, bool availability, string name)
        {
            if (availability && (id == 1 || id == 2) && (name == "Pickup" || name == "Car"))

            {
                Console.WriteLine("Vehicle is removed successsfully.");
                vehicle.Remove((new Vehicle(id, name, availability, fee, attack, life, 0, 0, 0)));
            }
        }
        public void getcondition(bool availability, int life, bool attack)
        {
            while (life > 0)
            {
                if (!availability && !attack)
                {
                    Console.WriteLine("Attacked");
                }
                life--;
            }
            if (life == 0)
            {
                Console.WriteLine("Expired!");
            }
        }
        public (int, int) getposition2dcooordinatesystem(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Position of vehicle is in origin.");
            }
            if (x > 0 && y == 0)
            {
                Console.WriteLine($"The position of vehicle is in the positive side in x-axis.It lies in x-axis.The current positiobn is:{x},{y}");
            }
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The position of vehicle is in the 1st quardrent.It lies in x-axis.The current positiobn is:{x},{y}");
            }
            if (x == 0 && y > 0)
            {
                Console.WriteLine($"The position of vehicle is in the positive side in y-axis.It lies in x-axis.The current positiobn is:{x},{y}");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine($"The position of vehicle is in 2nd quadrent.The current positiobn is:{x},{y}");
            }
            if (x < 0 && y == 0)
            {
                Console.WriteLine($"The position of vehicle is in the negative side in x-axis.It lies in x-axis.The current positiobn is:{x},{y}");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine($"The position of vehicle is in the 3rd quadrent.The current positiobn is:{x},{y}");
            }
            if (x == 0 && y < 0)
            {
                Console.WriteLine($"The position of vehicle is in the negative side in y-axis.It lies in y-axis.The current positiobn is:{x},{y}");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine($"The position of vehicle is in the 4th quadrent.The current positiobn is:{x},{y}");
            }
            return (x, y);
        }
        public (int, int, int) getposition3dcooordinatesystem(int x, int y, int z)
        {
            return (x, y, z);
        }
        public string getname()
        {
            return name;
        }
        public int getfee(int id)
        {
            int fee = id * 500;
            Console.WriteLine($"The Fee of vehicle is:{fee}");
            return fee;
        }
        public void getdamage(bool attack, int life)
        {
            while (!attack&&life>0)
            {
                life -= (life / 10);
                attack = true;
            }
           
            Console.WriteLine($"The present life is:{life}");
            if(life==0)
            {
                Console.WriteLine("Vehicle is fully damaged.It is expired.The present life is 0.");
            }
        }
    }
}
