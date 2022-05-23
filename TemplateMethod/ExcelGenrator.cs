﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ExcelGenrator : Generator
    {
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate excel file");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for excel");
        }
    }
}
