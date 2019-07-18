using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question12
{
    public class HomeComputerBuilder : ComputerBuilder
    {
        public override void AddComputerCase()
        {
            computer.AddComputerCase("thin computer case");
        }

        public override void AddCPU()
        {
            computer.AddCPU("medium cpu");
        }

        public override void AddGPU()
        {
            computer.AddGPU("strong gpu");
        }

        public override void AddMotherBoard()
        {
            computer.AddMotherBoard("thin motherboard");
        }

        public override void AddRAM()
        {
            computer.AddRAM("8GB RAM");
        }
    }
}
