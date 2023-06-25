using Application.basic_logic;

namespace UnitTest
{
    public class ArrayOperationsTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(3)]
        public void CreateArrayShouldReturnExpectedArraySize(int arraySize)
        {
            var array = ArrayOperations.CreateArray(arraySize);

            Assert.NotNull(array);
            Assert.Equal(arraySize, array.Length);
        }

        [Theory]
        [InlineData(3)]
        public void CreateArrayShouldReturnArrayWithSequencialValues(int arraySize)
        {
            var array = ArrayOperations.CreateArrayWithSequencial(arraySize);

            Assert.NotNull(array);
            Assert.Equal(arraySize, array.Length);
            array
                .Select((item, index) => (item, index))
                .ToList()
                .ForEach(x => {
                    Assert.Equal(x.index, x.item);
                });
        }

        [Theory]
        [InlineData(5, 3)]
        [InlineData(10, 7)]
        public void ReturnArrayPosShouldReturnArrayPos(int arraySize, int pos)
        {
            var array = ArrayOperations.CreateArrayWithSequencial(arraySize);

            var result = ArrayOperations.ReturnArrayPos(array, pos);

            Assert.NotNull(array);
            Assert.Equal(arraySize, array.Length);
            Assert.Equal(array[pos], result);
        }

        [Fact]
        public void JoinArraysShouldReturnCombinedArray()
        {
            var array1 = new string[] { "Fiesta", "Focus", "Fusion" };
            var array2 = new string[] { "Argo", "Strada", "Toro" };

            var result = ArrayOperations.JoinArrays(array1, array2);

            Assert.NotNull(result);
            Assert.NotEmpty(result);

            Assert.Equal("Fiesta", result[0]);
            Assert.Equal("Focus", result[1]);
            Assert.Equal("Fusion", result[2]);
            Assert.Equal("Argo", result[3]);
            Assert.Equal("Strada", result[4]);
            Assert.Equal("Toro", result[5]);
        }
    }
}
