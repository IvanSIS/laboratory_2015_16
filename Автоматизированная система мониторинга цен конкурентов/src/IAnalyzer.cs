﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    interface IAnalyzer
    {
        void AnalyzerInit();
        void AnalyzerHtmlPreparation(); 
    }
}
