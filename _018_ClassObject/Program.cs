class Cycle
{
    string make = "";
    int wheelNumb;
    string color = "";
    int year;

    static void Main()
    {
        Cycle Uni = new Cycle();
        Uni.make = "Circus Uni-Cycle";
        Uni.wheelNumb = 1;
        Uni.color = "clown orange";
        Uni.year = 1972;
        Console.WriteLine($"The {Uni.make} was made in {Uni.year} in Bulgaria and has {Uni.wheelNumb} wheel.");
        Console.WriteLine();  // space in output

        Cycle Trice = new Cycle();
        Trice.make = "Schwinn";
        Trice.wheelNumb = 3;
        Trice.color = "Silver";
        Trice.year = 1983;

        Console.WriteLine($"I have never seen a {Trice.year} {Trice.color} {Trice.make} {Trice.wheelNumb} wheeled bike.");
        Console.WriteLine();  // space in output

        Cycle Bycicle = new Cycle();
        Bycicle.make = "Schwinn";
        Bycicle.wheelNumb = 2;
        Bycicle.color = "Silver and Black";
        Bycicle.year = 1982;

        Console.WriteLine($"I used to have a {Bycicle.year} {Bycicle.color} {Bycicle.make} {Bycicle.wheelNumb} wheeled bike.");

    }

}
