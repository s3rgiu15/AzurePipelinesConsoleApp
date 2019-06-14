using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzurePipelinesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Azure Pipelines, Kynteix!");

            string releaseVariable = ConfigurationSettings.AppSettings["releaseVariable"];
            Console.WriteLine("Release var: " + releaseVariable);

            Console.ReadLine();
        }
    }
}
