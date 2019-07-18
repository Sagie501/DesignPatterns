using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question12
{
    public class Computer
    {
        private List<String> parts = new List<String>();

        public Computer()
        {
            // Add ComputerCase
            // Add Mother-Board
            // Add CPU
            // Add GPU
            // Add RAM
            // Run Check
        }

        public void AddComputerCase(String computerCase)
        {
            this.parts.Add(computerCase);
        }

        public void AddMotherBoard(String motherBaord)
        {
            this.parts.Add(motherBaord);
        }

        public void AddCPU(String cpu)
        {
            this.parts.Add(cpu);
        }

        public void AddGPU(String gpu)
        {
            this.parts.Add(gpu);
        }

        public void AddRAM(String ram)
        {
            this.parts.Add(ram);
        }

        public void RunCheck()
        {
            Console.WriteLine("The parts are:");
            foreach(String part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine("All parts built good!");
        }
    }
}
