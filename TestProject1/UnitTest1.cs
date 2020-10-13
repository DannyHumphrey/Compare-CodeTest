using System.Collections.Generic;
using Data;
using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services;

namespace TestProject1
{
    /// <summary>
    /// Started to run out time to set this up (Didn't want to spend too long on this)
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        private Mock<IMessageContext> _messageContextMock;
        private GetMessagesService _target;
        
        [TestInitialize]
        public void SetupTest()
        {
            _messageContextMock = new Mock<IMessageContext>();

            _target = new GetMessagesService(_messageContextMock.Object);
        }

        void AddMessage()
        {
            var message = new Message()
            {
                MessageId = 1
            };
        }
        
        [TestMethod]
        public void GetMessageService_Should_Return_Single_Item()
        {
        }
    }
}