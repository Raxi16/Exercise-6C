// See https://aka.ms/new-console-template for more information
double intialValue, growthRate, growthPeriod, timeTogrow, estPopulation;
Console.WriteLine("This program will predict the population growth.");
Console.WriteLine(" \n Please enter the intial number of organisms");
intialValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n Please enter the growth rate");
growthRate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n\n Please enter the number of hours it takes to achieve this rate");
growthPeriod = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n\n Please enter the number of hours during which the population");
timeTogrow = Convert.ToDouble(Console.ReadLine());
if (intialValue <= 0 && growthRate >= 0 && timeTogrow > 0) ;
{
    Console.WriteLine("Unable to calculate due to one of your values are 0");
}
else if (intialValue >= 1  || growthRate >= 1  || growthPeriod >= 1  || timeTogrow >= 1);
{
    estPopulation = intialValue * growthRate * (timeTogrow / growthPeriod);
    Console.WriteLine("\n\n The esitanted population is " + (estPopulation);
}
