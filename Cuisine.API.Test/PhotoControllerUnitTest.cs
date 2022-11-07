using Cuisine.API.Controllers;

namespace Cuisine.API.Test
{
    public class PhotoControllerUnitTest
    {
        [Fact]
        public void ShouldReturnListPhoto()
        {
            var controller = new PhotoController();

            var result = controller.TestAmoi();
            Assert.NotNull(result);
            //Assert.True(result.GetEnumerator().MoveNext());

        }
    }
}