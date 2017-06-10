﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramFlow.TaskDemos.Models
{
    public class ThreadPoolDemoContext
    {
        public ManualResetEvent ResetEvent { get; set; }

        public Dictionary<string, object> ContextData { get; set; }
    }
}
