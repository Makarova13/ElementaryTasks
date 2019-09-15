using System;
using Xunit;

namespace LuckyTicket.Test
{
    public class AlgorythmChooserTest
    {
        [Fact]
        public void GetAlgorithm_FromFile_PiterType()
        {
            string path = "C:/softserve/Tasks/LuckyTicket/ForTests/piter.txt";
            var result = AlgorithmChooser.GetAlgorithm(path);

            Assert.True(result is PiterTicketAlgorithm);
        }

        [Fact]
        public void GetAlgorithm_FromFile_MoskowType()
        {
            string path = "C:/softserve/Tasks/LuckyTicket/ForTests/moskow.txt";
            var result = AlgorithmChooser.GetAlgorithm(path);

            Assert.True(result is MoskowTicketAlgorithm);
        }

        [Fact]
        public void GetAlgorithm_FromFile_None()
        {
            string path = "C:/softserve/Tasks/LuckyTicket/ForTests/noType.txt";
            Assert.Throws<FormatException>(() => AlgorithmChooser.GetAlgorithm(path));
        }
    }
}
