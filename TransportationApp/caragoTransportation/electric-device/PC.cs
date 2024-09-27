using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inheritance
{
    public class PC
    {
        private string model;
        public PC(string model)
        {
            this.model = model;
        }

        public override string ToString()
        {
            return $"model is {model}";
        }
        public  string GetModel()
        {
            return model;
        }
    }
}
