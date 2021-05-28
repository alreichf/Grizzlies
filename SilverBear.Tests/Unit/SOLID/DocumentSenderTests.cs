using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using SilverBear.WebMVC.SOLID.InterfaceSegregation;
using SilverBear.WebMVC.SOLID.LISKOV;
using SilverBear.WebMVC.SOLID.OpenClosedPrinciple;
using SilverBear.WebMVC.SOLID.SRP;
using Xunit;

namespace SilverBear.Tests.Unit.SOLID
{
    public class DocumentSenderTests
    {
        private readonly IDocumentSender _documentSender;
        private readonly Mock<IDocumentFormatter> _mockDocumentFormatter;
        private readonly Mock<ISalaryCalculator> _mockSalaryCalculator;
        private readonly Mock<ISendMailService> _mockSendMailService;

        public DocumentSenderTests()
        {
            _mockDocumentFormatter = new Mock<IDocumentFormatter>();
            _mockSalaryCalculator = new Mock<ISalaryCalculator>();
            _mockSendMailService = new Mock<ISendMailService>();
            var _sendMailService = new EmailSendService();
            //_documentSender = new DocumentSender(_mockDocumentFormatter.Object, _mockSalaryCalculator.Object, _mockSendMailService.Object);
            _documentSender = new DocumentSender(_mockDocumentFormatter.Object, _mockSalaryCalculator.Object, _sendMailService);
        }

        [Fact]
        public async Task ShouldSendAnAnimal()
        {
            // Given
            var animal = new Dog();


            //_mockSendMailService.Setup(s => s.Send(It.IsAny<object>())).ReturnsAsync(true);
            // When
            var sent = await _documentSender.Send(animal);

            // Then
            sent.Should().BeTrue();
            //_mockSendMailService.Verify(s => s.Send(It.IsAny<object>()), Times.Once);
        }
    }
}
