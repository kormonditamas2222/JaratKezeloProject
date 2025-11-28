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
        public void HelyesMikorIndul()
        {
            jk.UjJarat("Pista", "BUD", "LAX", new DateTime(2023, 10, 12, 12, 0, 0));

            Assert.That(jk.MikorIndul("Pista"), Is.EqualTo(new DateTime(2023, 10, 12, 12, 0, 0)));
        }
    }
}
