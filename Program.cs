using Upcasting_downcasting.Models;
//#region Upcasting downcasting
//Bus bus = new Bus();
//Vehichle vehichle = bus;
//if (vehichle is Bus)
//{
//Bus bus1 = (Bus)vehichle;
//bus1.Drive();

//}
//else
//{
//    Console.WriteLine("Bus deyil");
//}

//Car car = new Car();
//Vehichle vehichle1 = car;
//Car car1 = vehichle as Car;
//if (car1 != null)
//{
//    car.Drive();
//    Console.WriteLine("Masindir");
//}
//else
//{
//    Console.WriteLine("Masindeyil");

//}

//#endregion

#region operator overload
Car car = new Car(50);

Car car1 = new Car(60);
Console.WriteLine(car>car1);
Console.WriteLine(car<car1);


#endregion