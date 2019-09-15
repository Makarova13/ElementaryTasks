using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicket.Test
{
    class LuckyTicketFixture
    {
        public MoskowTicketAlgorithm moskowAlgorithm;
        public PiterTicketAlgorithm piterAlgorithm;

        public LuckyTicketFixture()
        {
            moskowAlgorithm = new MoskowTicketAlgorithm();
            piterAlgorithm = new PiterTicketAlgorithm();
        }
    }
}
