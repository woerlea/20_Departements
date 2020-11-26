using System;
using System.IO;

namespace _20_Departments
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PersonenName;Abteilung
Franz Müller;Vorstand
Max Mustermann;Einkauf
Frida Haudrauf;Einkauf Europa
Alois Stich;Einkauf Europa
Bernd Muster;Einkauf Italien
Ulla Neu;Einkauf USA
Iris Tor;Vertrieb
Paul Hinter;Vertrieb Europa
Ernst Bock; Vertrieb Europa
Olga Peter; Vertrieb Europa
         */


            //Initiiere Abteilungen
            Department mBoard = new Department("Vorstand");
            Department purchasing = new Department("Einkauf");
            Department purchasingEU = new Department("Einkauf Europa");
            Department purchasingIT = new Department("Einkauf Italien");
            Department purchasingUSA = new Department("Einkauf USA");
            Department distribution = new Department("Vertrieb");
            Department distributionEU = new Department("Vertrieb Europa");

            // Departments zur Liste der Firme hinzufügen
            Department company = new Department("Abteilungen");
            company.AddDepartment(purchasing);
            company.AddDepartment(purchasingEU);
            company.AddDepartment(purchasingIT);
            company.AddDepartment(purchasingUSA);
            company.AddDepartment(distribution);
            company.AddDepartment(distributionEU);

            // Die Datei einlesen
            string URL = @"C:\Users\DCV\Documents\DigitalCampusAufgaben\OOP\OOP\20_Departments\Abteilungen.txt";
            string text = System.IO.File.ReadAllText(URL);
            Console.WriteLine(text);

            //Personen aus der.txt erzeugen
            try
            {
                //Textzeilen
                string[] lines = System.IO.File.ReadAllLines(URL);
                // Employees werden in Array gespeichert
                var employee = new Person[10];

                for (var i = 0; i < lines.Length - 1; i++)
                {
                    var splittedValues = lines[i].Split(';');

                    var person = new Person();
                    {
                        // Personen initialisieren und Abteilungen zuordnen (über Properties)
                        person.Name = splittedValues[0];
                        person.Department = splittedValues[1];
                        if (person.Department == "Vertrieb Europa")
                        {
                            distributionEU.AddEmployee(person);
                        }
                        if (person.Department == "Einkauf") 
                        {
                            purchasing.AddEmployee(person);
                        }
                        if (person.Department == "Vorstand")
                        {
                            mBoard.AddEmployee(person);
                        }
                        if (person.Department == "Einkauf Europa")
                        {
                            purchasingEU.AddEmployee(person);
                        }
                        if (person.Department == "Einkauf Italien")
                        {
                            purchasingIT.AddEmployee(person);
                        }
                        if (person.Department == "Einkauf USA")
                        {
                            purchasingUSA.AddEmployee(person);
                        }
                        if (person.Department == "Vertrieb")
                        {
                            distribution.AddEmployee(person);
                        }

                    }
                    // Personen werden gespeichert
                    employee[i] = person;
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("____");

            //mBoard.GetEmployee(); // wird nur der Name gedruckt
            //purchasing.GetEmployee();
            //purchasingEU.GetEmployee();
            //purchasingIT.GetEmployee();
            //purchasingUSA.GetEmployee();
            //distribution.GetEmployee();
            //distributionEU.GetEmployee();

            Console.WriteLine(mBoard.GetDepartmentEmployees());
            Console.WriteLine(purchasing.GetDepartmentEmployees());
            Console.WriteLine(purchasingEU.GetDepartmentEmployees());
            Console.WriteLine(purchasingIT.GetDepartmentEmployees());
            Console.WriteLine(purchasingUSA.GetDepartmentEmployees());
            Console.WriteLine(distribution.GetDepartmentEmployees());
            Console.WriteLine(distributionEU.GetDepartmentEmployees());            

        }
    }
}
