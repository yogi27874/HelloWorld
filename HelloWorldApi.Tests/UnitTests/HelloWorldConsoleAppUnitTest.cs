using System;
using System.Collections.Generic;
using HelloWorldConsoleApp.Service;
using HelloWorldLibrary.Model;
using Moq;
using NUnit.Framework;

namespace HelloWorldApi.Tests.UnitTests
{
    [TestFixture]
    public class HelloWorldConsoleAppUnitTest
    {
        private List<Exception> exceptionList;
        private List<object> objectList;
        private List<string> messageList;
        private Mock<IHelloWorldService> helloWorldServiceMock;
        private HelloWorldConsoleApp.App.HelloWorldConsoleApp helloWorldConsoleApp;

        [SetUp]
        public void InitializeTest()
        {
            exceptionList = new List<Exception>();
            objectList = new List<object>();
            messageList = new List<string>();
            
            helloWorldServiceMock = new Mock<IHelloWorldService>();
            helloWorldConsoleApp = new HelloWorldConsoleApp.App.HelloWorldConsoleApp(helloWorldServiceMock.Object);
        }
        [TearDown]
        public void TearDown()
        {
            exceptionList.Clear();
            objectList.Clear();
            messageList.Clear();
        }

        [Test]
        public void TestHelloWorldConsoleAppDataSuccess()
        {
            var data = "Hello World";
            var sampleData = GetSampleData(data);
            var origData = helloWorldServiceMock.Setup(x => x.GetData());
            helloWorldConsoleApp.Run(null);
            Assert.AreEqual(origData, sampleData);

        }
        private static Data GetSampleData(string data)
        {
            return new Data { stringData = data };
        }
    }
}
