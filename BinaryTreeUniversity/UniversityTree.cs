using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeUniversity
{
    class UniversityTree
    {
        public PositionNode Root;
        public int CountNodo = 0;
        private float HigherSalary = 0;

      

        public void CreatePosition(PositionNode parent, Position positionToCreate, string parentPositionName)
        {

            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;

            
                if (Root == null)
                {
                    Root = newNode;
                    return;
                }

                if (parent == null)
                {
                    return;
                }

                if (parent.Position.Name == parentPositionName)
                {
                    if (parent.Left == null)
                    {
                        parent.Left = newNode;
                        return;
                    }
                    parent.Right = newNode;
                    return;
                }
                CreatePosition(parent.Left, positionToCreate, parentPositionName);
                CreatePosition(parent.Right, positionToCreate, parentPositionName);
        }
        public void PrintTree(PositionNode from)
        {

            if(from == null)
            {
                return;
            }

            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");
           

            PrintTree(from.Left);
            PrintTree(from.Right);
           
        }
  
        public  float addSalaries(PositionNode from)
        {

            if(from == null)
            {
                return 0;
            }
            return from.Position.Salary + addSalaries(from.Left) + addSalaries(from.Right);

        }
        
        public int Node(PositionNode nodo)
        {
            if (nodo != null)
            {
                Node(nodo.Left); Node(nodo.Right);

                CountNodo++;
            }
           return CountNodo;
        }
        public float AvarageSalary(PositionNode from, int cant)
        {
            return (((from.Position.Salary + addSalaries(from.Left) + addSalaries(from.Right))/cant));

        }
        public float AddTax(PositionNode from)
        {

            if (from == null)
            {
                return 0;
            }
             return ((from.Position.Salary * from.Position.Tax/100) + AddTax(from.Left) + AddTax(from.Right));
        }
       

        public float getHigherSalary()
        {
            return HigherSalary;
        }

        public void setHigherSalary(float salary)
        {
            this.HigherSalary = salary;
        }

        public void AddHigherSalary(PositionNode from)
        {
            if (from == null)
            {
                return;
            }

            if (from != Root)
            {
                if (from.Position.Salary > getHigherSalary())
                {
                    setHigherSalary(from.Position.Salary);
                }
            }
            AddHigherSalary(from.Left); AddHigherSalary(from.Right);
        }

        public float PositionSalary(PositionNode from, string name)
        {
            if (from == null)
            {
                return 0;
            }

            if (from.Position.Name == name)
            {
                return from.Position.Salary;
            }
            return PositionSalary(from.Left, name) + PositionSalary(from.Right, name);

            if (from.Position.Salary == 0)
            {
                Console.WriteLine("No existe");
            }
        }
    }
}
