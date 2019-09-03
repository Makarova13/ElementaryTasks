using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationsWithNums;

namespace LuckyTicket
{
    public class Ticket
    {
        public bool IsLucky { get; set; }

        public byte[] Number { get; set; }

        public int Length { get => Number.Length; }

        public byte this[int index]
        {
            get
            {
                return Number[index];
            }
        }
    }
}
