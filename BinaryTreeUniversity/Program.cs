using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;
            rectorPosition.Tax = 30;


            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector Financiero";
            vicFinPosition.Salary = 750;
            vicFinPosition.Tax = 20;


            Position contadorPosition = new Position();
            contadorPosition.Name = "contador";
            contadorPosition.Salary = 500;
            contadorPosition.Tax = 10;


            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.Tax = 11;


            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaría Financiera 1 ";
            secFin1Position.Salary = 350;
            secFin1Position.Tax = 5;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaría Financiera 2 ";
            secFin2Position.Salary = 310;
            secFin2Position.Tax = 6;

            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "Vicerector academico";
            vicAcadPosition.Salary = 780;
            vicAcadPosition.Tax = 8;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe de Registro";
            jefeRegPosition.Salary = 640;
            jefeRegPosition.Tax = 9;

            Position sectReg2 = new Position();
            sectReg2.Name = "Secretario de registro 2";
            sectReg2.Salary = 360;
            sectReg2.Tax = 17;

            Position sectReg1 = new Position();
            sectReg1.Name = "Secretario de registro 1";
            sectReg1.Salary = 400;
            sectReg1.Tax = 16;

            Position asist2 = new Position();
            asist2.Name = "Asistente 2";
            asist2.Salary = 170;
            asist2.Tax = 25;

            Position asist1 = new Position();
            asist1.Name = "Asistente 1";
            asist1.Salary = 250;
            asist1.Tax = 26;

            Position mensajero = new Position();
            mensajero.Name = "mensajero";
            mensajero.Salary = 90;
            mensajero.Tax = 27;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);

            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);


            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, sectReg2, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, sectReg1, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2, sectReg1.Name);
            universityTree.CreatePosition(universityTree.Root, asist1, sectReg1.Name);
            universityTree.CreatePosition(universityTree.Root, mensajero, asist2.Name);

            universityTree.PrintTree(universityTree.Root);
            Console.WriteLine("Total salaries = " + universityTree.addSalaries(universityTree.Root));


            Console.WriteLine(" *-----------↑↑↑↑ First delivery ↑↑↑↑ ------------*");
            Console.WriteLine(" *-----------↓↓↓↓ Second delivery ↓↓↓↓------------*");

            int TotalNodes = universityTree.Node(universityTree.Root);
            
            universityTree.AddHigherSalary(universityTree.Root);
            float AverageSalary = universityTree.AvarageSalary(universityTree.Root, TotalNodes);
          
            Console.WriteLine("Higher salary  = " + universityTree.getHigherSalary());
            Console.WriteLine("Average salary  = " + AverageSalary);
            Console.WriteLine("The total Tax is = " + universityTree.AddTax(universityTree.Root));
            Console.WriteLine("Write name to search");
            string name = Console.ReadLine();
            Console.WriteLine(" the position salary is entered = " + universityTree.PositionSalary(universityTree.Root, name));
            Console.ReadLine();
        }
    }
}
