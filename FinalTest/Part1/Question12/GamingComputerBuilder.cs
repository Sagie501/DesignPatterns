using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question12
{
    public class GamingComputerBuilder : ComputerBuilder
    {
        public override void AddComputerCase()
        {
            computer.AddComputerCase("Big computercase");
        }

        public override void AddCPU()
        {
            computer.AddCPU("Very strong cpu");
        }

        public override void AddGPU()
        {
            computer.AddGPU("Very Strong GPU");
        }

        public override void AddMotherBoard()
        {
            computer.AddMotherBoard("Good motherboard");
        }

        public override void AddRAM()
        {
            computer.AddRAM("32GB RAM");
        }
    }
}
