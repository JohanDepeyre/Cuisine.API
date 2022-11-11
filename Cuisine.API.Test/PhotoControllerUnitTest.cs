using Cuisine.API.Controllers;
using Cuisine.Core.Domain;
using Cuisine.Core.Domain.Repository;
using Cuisine.Core.Framework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Moq;
using System.Collections.ObjectModel;

namespace Cuisine.API.Test
{
    public class PhotoControllerUnitTest
    {
        [Fact]
        public void ShouldAddPhoto()
        {
            Photo photo = new Photo();
            var repositoryMock = new Mock<IPhotoRepository>();
            repositoryMock.Setup(item => item.unitOfWork).Returns(new Mock<IUnitOfWork>().Object);
         
            var controller = new PhotoController(repositoryMock.Object);
            
           var result = controller.AddOne(photo);
            Assert.NotNull(result);

      

        }
        [Fact]
        public void ShouldReturnListPhoto()
        {
            var repositoryMock = new Mock<IPhotoRepository>();
           
            repositoryMock.Setup(item => item.GetAll());
            var controller = new PhotoController(repositoryMock.Object);

            var result = controller.GetAll(1);
            Assert.NotNull(result);
           
            //Assert.True(result.GetEnumerator().MoveNext());
           

        }
    }
}