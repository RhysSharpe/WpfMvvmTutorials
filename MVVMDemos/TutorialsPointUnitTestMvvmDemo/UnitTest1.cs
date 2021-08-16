using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TutorialsPointDemo.ViewModel;

namespace TutorialsPointUnitTestMvvmDemo
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]

        public void TestMethod1()
        {
            StudentViewModel sViewModel = new StudentViewModel();
            int count = sViewModel.GetStudentCount();
            Assert.IsTrue(count == 3);
        }
    }
}
