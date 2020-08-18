using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plana.Models;
using System;

namespace UnitTestPlana
{
    [TestClass]
    public class UnitTestLecturer
    {
        [TestMethod]
        public void LecturerSetTocken()
        {
            Lecturer lecturer = new Lecturer();
            lecturer.FirstName = "Pavel";
            lecturer.LastName = "Goncharov";
            lecturer.BirthDate = new DateTime(1981, 02,11);
            Assert.IsTrue(lecturer.FirstName == "Pavel");
            //  Assert.IsTrue(lecturer.Token == "PAGO11");
            Console.WriteLine(lecturer.Token);

        }

        [TestMethod]
        public void LecturerAddModule() {
            LecturersModules lm = new LecturersModules();
            Module m = new Module();
            Lecturer l = new Lecturer();
             lm.Module = m;
             lm.Lecturer = l;

            Assert.IsTrue(lm.Lecturer == l && lm.Module == m);
            
        
        }
    }
}
