using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Online_E_Grocecry.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using Online_E_Grocecry.Controllers;
using Online_E_Grocecry.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace TestProject
{
    [TestClass]
    public class ItemControllerTest
    {

        private Mock<IItems> _itemRepoMock;
        private Fixture _fixture;
        private ItemsController _controller;
        public ItemControllerTest()
        {
            _fixture = new Fixture();
            _itemRepoMock = new Mock<IItems>();
        }
        [TestMethod]

        public async Task GetItemsReturnOk()
        {
            var itemList = _fixture.CreateMany<Items>(3).ToList();
            _itemRepoMock.Setup(repo => repo.Get()).Returns(itemList);
            _controller = new ItemsController(_itemRepoMock.Object);
            var result = await _controller.Get();
            var obj = result as ObjectResult;
            Assert.AreEqual(200, obj.StatusCode);
        }
        [TestMethod]
        public async Task GetItemsThrowException()
        {
            _itemRepoMock.Setup(repo => repo.Get()).Throws(new Exception());
            _controller = new ItemsController(_itemRepoMock.Object);
            var result = await _controller.Get();
            var obj = result as ObjectResult;
            Assert.AreEqual(500, obj.StatusCode);
        }
        [TestMethod]
        public async Task AddItemsReturnOk()
        {
            var item = _fixture.Create<Items>();
            _itemRepoMock.Setup(repo => repo.Post(It.IsAny<Items>())).Returns(item);
            _controller = new ItemsController(_itemRepoMock.Object);
            var result = await _controller.Post(item);
            var obj = result as ObjectResult;
            Assert.AreEqual(200, obj.StatusCode);
        }
        [TestMethod]
        public async Task AddItemsThrowException()
        {
            _itemRepoMock.Setup(repo => repo.Get()).Throws(new Exception());
            _controller = new ItemsController(_itemRepoMock.Object);
            var result = await _controller.Get();
            var obj = result as ObjectResult;
            Assert.AreEqual(500, obj.StatusCode);
        }
    }
}

