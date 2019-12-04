using System;
using System.Collections.Generic;
using System.Text;
using Lab.core;

namespace Lab.cerber
{
    class MyLog : core.LogAbstract<MyLog>, core.LogInterface
    {
        override public void _write()
        {
            foreach (var entry in log)
            {
                Console.Write(entry);
            }
        }

        public void Write()
        {
            _write();
        }

        public void Log(string str)
        {
            log.Add(str);
        }
    }
}
