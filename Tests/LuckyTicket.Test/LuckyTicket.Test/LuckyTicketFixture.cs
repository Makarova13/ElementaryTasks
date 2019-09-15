using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicket.Test
{
    public class LuckyTicketFixture
    {
        public MoskowTicketAlgorithm MoskowAlgorithm { get; private set; }
        public PiterTicketAlgorithm PiterAlgorithm { get; private set; }

        public LuckyTicketFixture()
        {
            MoskowAlgorithm = new MoskowTicketAlgorithm();
            PiterAlgorithm = new PiterTicketAlgorithm();
        }
    }
}
