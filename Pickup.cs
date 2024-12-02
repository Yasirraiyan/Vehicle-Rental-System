    public class Pickup
    {
        public int load;
        public int seat;
        public Vehicle vehicle;
        public bool availability = false;
        public int x;
        public int y;
        public int z;
        public bool attack = false;
        public Pickup(int load, int seat, Vehicle vehicle, bool availability, int x, int y, int z, bool attack)
        {
            this.load = load;
            this.seat = seat;
            this.vehicle = vehicle;
            this.availability = availability;
            this.x = x;
            this.y = y;
            this.z = z;
            this.attack = attack;
        }
        public (int, int, bool) checkpickup(int load, int seat, bool avalability)
        {
            if (load > 0 && seat > 0 && !avalability)
            {
                Console.WriteLine("Pickup is perfect");
            }
            else
            {
                Console.WriteLine("Pickup not perfect");
            }
            return (load, seat, avalability);
        }
        public int getload(int load)
        {
            return load;
        }
        public int getseat(int seat)
        {
            return seat;
        }
        public int calculatefare(int seat)
        {
            int fare = seat * 500;
            Console.WriteLine($"The fare of pickup is:{fare}");
            return fare;
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
        public void getdamage(bool attack, int life)
        {
            while (!attack && life > 0)
            {
                life -= (life / 100);
                attack = true;
            }

            Console.WriteLine($"The present life is:{life}");
            if (life == 0)
            {
                Console.WriteLine("Vehicle is fully damaged.It is expired.The present life is 0.");
            }
        }
    }
}
