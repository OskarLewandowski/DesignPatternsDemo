using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Generator
    {
        public void GenerateReport()
        {
            GetData();
            PrepareData();
            GenerateFile();
            SendFile();
        }

        //we can override this method, in this example
        protected virtual void GetData()
        {
            Console.WriteLine("Base get data");
        }

        //this method we must implement, in this example
        protected abstract void PrepareData();

        //this method we must implement, in this example
        protected abstract void GenerateFile();

        //we can't override this method, in this example 
        protected void SendFile()
        {
            Console.WriteLine("Sending generated report");
        }

    }
}
