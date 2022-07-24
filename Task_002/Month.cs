using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    internal class Month
    {
        private byte _number, _days;
        private string _name;

        public byte GetByMonthNumber { get => _number; }
        public string GetByMonthName { get => _name; }
        public byte GetByMonthDays { get => _days; }

        public Month(byte number, string name, byte days)
        {
            _number = number;
            _days = days;
            _name = name;
        }

        public void Show()
        {
            Console.WriteLine($"{GetByMonthNumber} / {GetByMonthName} / {GetByMonthDays}");
        }
    }
}
