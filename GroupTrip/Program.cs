﻿/*
 * Name:        Justin Williams
 * Course:      CSCI 1250, Section 002
 * Assignment:  Lab 04, Trip Calculator
 * Date:        October 14, 2026
 * Description: Calculates the food, fuel, and work hours behind one road trip.
 */

// Constants
const int slicesperPizza = 8;
const double taxRate = 0.18;

// PART 0: Initial Math
System.Console.Write("Round trip miles: ");
int miles = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Miles per gallon: ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How many pizzas: ");
int pizzas = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Price per pizza: ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

double pizzaCost = pizzas * pizzaPrice;
double tripTotal = FuelCost(miles, milesPerGallon, pricePerGallon) + pizzaCost;

// Part 1: The Trip
System.Console.WriteLine("\n=== Part 1: The Trip ===");
System.Console.WriteLine("Fuel Cost: " + FuelCost(miles, milesPerGallon, pricePerGallon).ToString("C"));
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));


// Part 2: The Group
string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

double totalSlices = slicesperPizza * pizzas;
double slicesPerPerson = totalSlices / names.Length;
double costPerPerson = tripTotal / names.Length;

System.Console.WriteLine("\n=== Part 2: The Group ===");
System.Console.WriteLine("People going: " + names.Length);
System.Console.WriteLine("Slices each: " + slicesPerPerson.ToString("F1"));
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));

/*
// Calculates the math
double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

// Output
System.Console.WriteLine("\nGallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));

// PART 2: PIZZA PARTY
System.Console.WriteLine("\n=== Part 2: Pizza Party ===");
int peopleGoing = Convert.ToInt32(Console.ReadLine());

// How many slices per pizza, and how many slices total that makes, and price

// Pizzas Output
System.Console.WriteLine("\nTotal slices: " + totalSlices);
System.Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));

// Paycheck input
System.Console.WriteLine("\n=== Part 3: Paycheck ===");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

double hourlyRate = Convert.ToDouble(Console.ReadLine());

// Calculating three things
double grossPay = hoursWorked * hourlyRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

// Paycheck Output
System.Console.WriteLine("\nGross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

// The Whole Trip - Calculations
double costPerPerson = tripTotal / peopleGoing;
double takeHomePayPerHour = takeHomePay / hoursWorked;
double hoursNeeded = costPerPerson / takeHomePayPerHour;

// The Whole Trip - Output
System.Console.WriteLine("\n=== Part 4: The Whole Trip ===");
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
System.Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
System.Console.WriteLine("Hours you must work to cover your share: " + hoursNeeded.ToString("F2"));

*/

// Methods
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}

static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double TakeHomePay = hours * hourlyRate;
    return TakeHomePay * (1-taxRate);
}

static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    double HoursToCover = amountOwed / takeHomePerHour;
    return HoursToCover;
}