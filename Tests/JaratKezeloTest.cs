using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezeloProject.Tests
{
    [TestFixture]
    public class JaratKezeloTest
    {
        static JaratKezelo jk = new();
        
        [Test]
        public void HelyesJaratokRepuloterrol()
        {
            jk.UjJarat("Feri", "BUD", "LAX", new DateTime(2023, 10, 12, 12, 0, 0));
            jk.UjJarat("Béla", "BUD", "LAX", new DateTime(2024, 10, 12, 12, 0, 0));

            Assert.That(jk.JaratokRepuloterrol("BUD"), Is.EqualTo(new List<string>(["Feri", "Béla"])));
        }
        [Test]
        public void HelyesMikorIndul()
        { 
            Assert.That(jk.MikorIndul("Feri"), Is.EqualTo(new DateTime(2023, 10, 12, 12, 0, 0)));
        }
    }
}
