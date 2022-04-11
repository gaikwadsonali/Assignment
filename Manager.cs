using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Emploees
    {
        protected double netsal { get; set; }

        protected double grsal { get; set; }
        protected double TA { get; set; }
        protected double PF { get; set; }

        protected double TDS { get; set; }
        protected double HRA { get; set; }
        protected double salary { get; set; }
        protected double DA { get; set; }
        public string emname { get; set; }
        public int emid { get; set; }

        public void getdetais()
        {

            Console.WriteLine("enter name of employee" + emname);
            emname = Console.ReadLine();
            Console.Write(" Enter Basic salary " + salary);
            salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter employee id" + emid);

            emid = Convert.ToInt32(Console.ReadLine());

        }

        public virtual void cal()
        {
            HRA = salary * 30 / 100;
            TA = salary * 25 / 100;
            DA = salary * 35 / 100;
            grsal = salary + HRA + TA + DA;


        }
        public virtual void Grossalary()
        {
           
            Console.Write("gross salary is:" + netsal);
        }
        public virtual void CalculateSalary()
        {
            PF = grsal * 10 / 100;
            TDS = grsal * 18 / 100;
            netsal = grsal - (PF + TDS);


        }
       



    }
    public class Manager : Emploees
    {
        protected double petrolal { get; set; }

        protected double foodal { get; set; }

        protected double otherall { get; set; }

        public Manager()
        {

            petrolal = salary * 8 / 100;
            foodal = salary * 13 / 100;
            otherall = salary * 3 / 100;
        }
        public override void Grossalary()
        {
            netsal= (grsal + petrolal + foodal + otherall);
            Console.WriteLine(netsal);

        }

        public override void cal()
        {
            grsal = (grsal + petrolal + foodal + otherall);
            Console.WriteLine(grsal);
       ppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppp