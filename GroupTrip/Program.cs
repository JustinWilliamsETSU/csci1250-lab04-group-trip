﻿/*
 * Name:        Justin Williams
 * Course:      CSCI 1250, Section 002
 * Assignment:  Lab 04, The Group Trip
 * Date:        October 14, 2026
 * Description: Rebuilds the trip calculator with methods and arrays so it reports on a whole group instead of one person.
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
int[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

double totalSlices = slicesperPizza * pizzas;
double slicesPerPerson = totalSlices / names.Length;
double costPerPerson = tripTotal / names.Length;
int totalHoursWorked = 0;
double totalTakeHomePay = 0;
double longestWorked = 0;

System.Console.WriteLine("\n=== Part 2: The Group ===");
System.Console.WriteLine("People going: " + names.Length);
System.Console.WriteLine("Slices each: " + slicesPerPerson.ToString("F1"));
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));


// Part 3: The Report
System.Console.WriteLine("\n=== Part 3: Who Works How Long ===");
for (int i = 0; i < names.Length; i++)
{
    double takeHome = TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate);
    double takeHomePerHour = hourlyRates[i] * (1 - taxRate);
    double hoursToCoverShare = HoursToCover(costPerPerson, takeHomePerHour);

    totalHoursWorked += hoursWorked[i];
    totalTakeHomePay += takeHome;
    longestWorked = Math.Max(longestWorked, hoursToCoverShare);

    Console.WriteLine(names[i] + ": takes home " + takeHome.ToString("C") + " for " + hoursWorked[i] + " hours, " + takeHomePerHour.ToString("C") + " per hour, must work " + hoursToCoverShare.ToString("F2") + " hours");
}

System.Console.WriteLine("\nTotal hours worked: " + totalHoursWorked);
System.Console.WriteLine("Total take home pay: " + totalTakeHomePay.ToString("C"));
System.Console.WriteLine("Longest anyone must work: " + longestWorked.ToString("F2"));

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