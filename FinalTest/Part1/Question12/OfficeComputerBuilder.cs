using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question12
{
    public class OfficeComputerBuilder : ComputerBuilder
    {
        public override void AddComputerCase()
        {
            computer.AddComputerCase("medium computercase");
        }

        public override void AddCPU()
        {
            computer.AddCPU("Medium cpu");
        }

        public override void AddGPU()
        {
            computer.AddGPU("Medium gpu");
        }

        public override void AddMotherBoard()
        {
            computer.AddMotherBoard("medium motherboard");
        }

        public override void AddRAM()
        {
            computer.AddRAM("8GB RAM");
        }
    }
}
