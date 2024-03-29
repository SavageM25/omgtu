using System;

// Машина

class Car {
    public string year;
    public string color;
    public string type;
    public string owner;
    public string healthcheck;
    
    public Car(string Year, string Color, string Type, string Owner, string Healthcheck) {
        year = Year;
        color = Color;
        type = Type;
        owner = Owner;
        healthcheck = Healthcheck;
    }

    public void Info() {
        Console.WriteLine($"A {color} {type} of {year} year. Owned by {owner}, healthchecked in {healthcheck} year.");
    }
}

class Program {
    public static void Main(string[] args) {
         Car[] cars = new Car[4] {
             new Car("1980", "черный", "Bently", "Вадим", "2004"),
             new Car("2018", "белый", "Toyota", "Коля", "2020"),
             new Car("1960", "коричневый", "Porshe", "Вася", "1970"),
             new Car("2001", "красный", "Lada", "Петя", "2009"),
         };

         Console.WriteLine("Введите (1) для выборки по году выпуска, (2) по марке, (3) по году тех осмотра");
         int option = Convert.ToInt32(Console.ReadLine());

         if (option == 1) {
             string year = Console.ReadLine();

             for (int i = 0; i < cars.Length; i++) {
                 if (cars[i].year == year) {
                     cars[i].Info();
                 }
             }

         } else if (option == 2) {
             string type = Console.ReadLine();

             for (int i = 0; i < cars.Length; i++) {
                 if (cars[i].type == type) {
                     cars[i].Info();
                 }
             }

         } else if (option == 3) {
             string healthcheck = Console.ReadLine();

             for (int i = 0; i < cars.Length; i++) {
                 if (cars[i].healthcheck == healthcheck) {
                     cars[i].Info();
                 }
             }

         }
    }
}