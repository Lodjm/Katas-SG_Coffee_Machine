using Coffee_Machine_Menu.DataAccess;

namespace Coffee_Machine_MenuDisplay.DataAccess
{
    public class BaseRepositoryTests
    {
        [Fact]
        public void Get_Data_Should_Return_IEnumerableData()
        {
            //Arrange
            var target = new BaseRepository("test.json", "_dataTest");

            //Act
            var result = target.GetData<DummyData>();

            //Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);

            Assert.Equal(2, result.Count());
            Assert.Contains(result, t => t.Name == "Test1");
            Assert.Contains(result, t => t.Name == "Test2");
        }

        [Theory]
        [InlineData("unknown.json", "_dataTest")]
        [InlineData("test.json", "_dataTest2")]
        [InlineData("", "_dataTest")]
        [InlineData("test.json", "")]
        public void Get_Data_Should_Return_IEnumerableEmpty_If_Directory_Of_File_Are_Incorrect(string file, string path)
        {
            //Arrange
            var target = new BaseRepository(file, path);

            //Act
            var result = target.GetData<DummyData>();

            //Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }
    }
}