using Souřadnice;
using System.Security.Cryptography;

Coordinates prvni = new Coordinates(5, 6);
Console.WriteLine(prvni.Equals(new Coordinates(5, 6)));
Console.WriteLine(prvni.CompareTo(new Coordinates(11, 9)));
Console.WriteLine();