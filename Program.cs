using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Xml.Linq;
using ConsoleApp1прмоитльд;



namespace С_Metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building[] builder = new Building[5];
            Settlement settlement = new Settlement(500);
            builder[0] = new Building("svinofarmya", 10, 100);
            builder[1] = new Building("fermya golemov", 10, 100);
            builder[2] = new Building("fermya snezhny golemov", 1000, 10000);
            builder[3] = new Building("fermya golemov", 10, 100);
            builder[4] = new Building("fermya golemov", 10, 100);
            GameManager gameManager = new GameManager(settlement, 10);
            builder[0].DisplayInfo();
            builder[1].DisplayInfo();
            builder[2].DisplayInfo();
            settlement.AddBuilding(builder[0]);
            settlement.AddBuilding(builder[1]);
            settlement.AddBuilding(builder[2]);
            settlement.ShowBuildings();
            gameManager.SimulateProduction();
        }
    }
}
    