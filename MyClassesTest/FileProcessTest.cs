using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest:TestBase
    {
        private const string existFileName = @"E:\personal\UnitTest\MyClassesTest\FileProcessTest.cs";
        private const string badFileName = @"E:\personal\UnitTest\MyClassesTest\FileNotFound.cs";

        [TestMethod]
        [Owner("Anar")]
        public void FileNameDoesExist()
        {
            //means unit test code not finished in this method
            //Assert.Inconclusive();

            //arrange
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            //assert
            fromCall = fileProcess.FileExists(existFileName);

            //assert
            TestContext.WriteLine($"checking file {existFileName}");
            Assert.IsTrue(fromCall, "{0} salam", existFileName);
        }
        [TestMethod]
        public void FileNameDoesNotExist()
        {
            //arrange
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            //assert
            fromCall = fileProcess.FileExists(badFileName);

            //assert
            TestContext.WriteLine($"checking file that is not exist {badFileName}");
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingAttribute()
        {
            FileProcess fileProcess = new FileProcess();

            TestContext.WriteLine("checking null for fileName");
            fileProcess.FileExists("");
        }

        [TestMethod]
        public void FileNameNullOrEmpty_UsingTryCatch()
        {
            FileProcess fileProcess = new FileProcess();

            try
            {
                TestContext.WriteLine("checking null for fileName");
                fileProcess.FileExists("");
            }
            catch (ArgumentNullException)
            {
                //Test was a success
                return;
            }
            Assert.Fail("Call to FileExist() method didnt throw an ArgumentNullException");
        }
    }
}
