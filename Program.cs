using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Votre poids?");  //Affiche un message pour demander le poids de l'utilisateur
            double weight = double.Parse(Console.ReadLine());  //Affecte la valeur de l'utilisateur convertie en double à la variable "weight"
            Console.WriteLine("Votre taille?");
            double height = double.Parse(Console.ReadLine());
            double imc = Math.Round(weight / Math.Pow(height, 2),2); //Calcul du poids par la taille ² ou ^2 et affecte la valeur à la variable "imc"  Math.Round permet d'arrondir au (dixième,centième,etc..) après la virgule.
            Console.WriteLine("Voila votre IMC "+imc); //Affiche la valeur imc
            if (imc < 10 || imc > 60)  // "if"= Si l'imc est inférieur à 10 "||" ou l'imc est supérieur à 60 alors on affiche un message d'erreur
            {
                Console.WriteLine("Vous ne devriez pas être vivant");
            }
            else if (imc <= 16.5 && imc > 10)
            {
                Console.WriteLine("Dénutrition");
            }
            else if (imc <= 18.5 && imc > 16.5)
            {
                Console.WriteLine("Maigreur");
            }
            else if (imc <= 25 && imc > 18.5)
            {
                Console.WriteLine("Corpulence normale");
            }
            else if (imc <= 30 && imc > 25)
            {
                Console.WriteLine("Surpoids");
            }
            else if (imc <= 35 && imc > 30)
            {
                Console.WriteLine("Obésité modérée");
            }
            else if (imc <= 40 && imc > 35)
            {
                Console.WriteLine("Obésité sévère");
            }
            else if (imc <= 60 && imc > 40)
            {
                Console.WriteLine("Obésité morbide ou massive");
            }
            else
            {
                Console.WriteLine("Oops, une erreur est survenue");
            }
        }
    }
}