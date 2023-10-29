﻿using Fussballmannschaft;
using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Fussballmannschaft team1 = new Fussballmannschaft();
            Fussballmannschaft team2 = new Fussballmannschaft();

            Torwart goalkeeper1 = new Torwart();
            Torwart goalkeeper2 = new Torwart();

            Feldspieler player1 = new Feldspieler();
            Feldspieler player2 = new Feldspieler();

            // Ausführung eines Spielzugs
            Methode method = new Methode();
            int result = method.FussballmannschaftSpielzug(team1, goalkeeper1, player1);

            // Ausgabe des Ergebnisses
            Console.WriteLine($"Ergebnis: {result}");

            // Beispielaufrufe der Methoden und Funktionen
            player1.AufsTorSchiessen("Spieler 1");
            player2.Graetschen("Spieler 2");
            player1.Dribbeln("Spieler 1");
            goalkeeper1.SchussHalten("Torwart 1");
            goalkeeper2.Abstoss();
        }
    }
}