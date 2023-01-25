using Xunit;
using ArrayUtils;
using MathUtils;
public class Tests
{

    [Fact]
    public void ArrayTests()
    {
        {
            int[] nums = { 1, 1, 2, -1, 2, 3 };

            Assert.Equal(8.0 / 6, ArrayUtilities.Average(nums));
            Assert.Equal(3, ArrayUtilities.Max(nums));
            Assert.Equal(-1, ArrayUtilities.Min(nums));

            Assert.Equal(new int[] { -1, 1, 1, 2, 2, 3 }, ArrayUtilities.SortAscending(nums));
            Assert.Equal(new int[] { 3, 2, 2, 1, 1, -1 }, ArrayUtilities.SortDescending(nums));

            Assert.Equal(8, ArrayUtilities.Sum(nums));
            Assert.Equal(-12, ArrayUtilities.Product(nums));

            Assert.Equal(new int[] { 3, 2, -1, 2, 1, 1 }, ArrayUtilities.Reverse(nums));

            Assert.Equal(1.5, ArrayUtilities.Median(nums));
            Assert.Throws<Exception>(() => ArrayUtilities.Mode(nums)); //nums has no mode so it should cry like a baby
            Assert.Equal(new int[] { 2, 2, 3, 0, 3, 4 }, ArrayUtilities.AddToAll(nums, 1));

            Assert.Equal(new int[] { 1, 1, 2, -1, 2, 3, 5 }, ArrayUtilities.Append(nums, 5));
            Assert.Equal(new int[] { 1, 1, 2, 2, 3 }, ArrayUtilities.Remove(nums, 3));

            Assert.Equal(true, ArrayUtilities.Contains(nums, 3)); //test both cases
            Assert.Equal(false, ArrayUtilities.Contains(nums, 69));

            Assert.Equal(3, ArrayUtilities.IndexOf(nums, -1));
            Assert.Equal(-1, ArrayUtilities.IndexOf(nums, 69));
            Assert.Equal(2, ArrayUtilities.HowMany(nums, 2));

            nums = new int[] {1, 2, -1, 2, 3 }; // test mode properly
            Assert.Equal(2, ArrayUtilities.Mode(nums));
        }
        {
            float[] nums = { 1, 1, 2, -1, 2, 3 };

            Assert.Equal(8.0f / 6, ArrayUtilities.Average(nums));
            Assert.Equal(3, ArrayUtilities.Max(nums));
            Assert.Equal(-1, ArrayUtilities.Min(nums));

            Assert.Equal(new float[] { -1, 1, 1, 2, 2, 3 }, ArrayUtilities.SortAscending(nums));
            Assert.Equal(new float[] { 3, 2, 2, 1, 1, -1 }, ArrayUtilities.SortDescending(nums));

            Assert.Equal(8, ArrayUtilities.Sum(nums));
            Assert.Equal(-12, ArrayUtilities.Product(nums));

            Assert.Equal(new float[] { 3, 2, -1, 2, 1, 1 }, ArrayUtilities.Reverse(nums));

            Assert.Equal(1.5, ArrayUtilities.Median(nums));
            Assert.Throws<Exception>(() => ArrayUtilities.Mode(nums)); //nums has no mode so it should cry like a baby
            Assert.Equal(new float[] { 2, 2, 3, 0, 3, 4 }, ArrayUtilities.AddToAll(nums, 1));

            Assert.Equal(new float[] { 1, 1, 2, -1, 2, 3, 5 }, ArrayUtilities.Append(nums, 5));
            Assert.Equal(new float[] { 1, 1, 2, 2, 3 }, ArrayUtilities.Remove(nums, 3));

            Assert.Equal(true, ArrayUtilities.Contains(nums, 3)); //test both cases
            Assert.Equal(false, ArrayUtilities.Contains(nums, 69));

            Assert.Equal(3, ArrayUtilities.IndexOf(nums, -1));
            Assert.Equal(2, ArrayUtilities.HowMany(nums, 2));
        }

        {
            double[] nums = { 1, 1, 2, -1, 2, 3 };

            Assert.Equal(8.0 / 6, ArrayUtilities.Average(nums));
            Assert.Equal(3, ArrayUtilities.Max(nums));
            Assert.Equal(-1, ArrayUtilities.Min(nums));

            Assert.Equal(new double[] { -1, 1, 1, 2, 2, 3 }, ArrayUtilities.SortAscending(nums));
            Assert.Equal(new double[] { 3, 2, 2, 1, 1, -1 }, ArrayUtilities.SortDescending(nums));

            Assert.Equal(8, ArrayUtilities.Sum(nums));
            Assert.Equal(-12, ArrayUtilities.Product(nums));

            Assert.Equal(new double[] { 3, 2, -1, 2, 1, 1 }, ArrayUtilities.Reverse(nums));

            Assert.Equal(1.5, ArrayUtilities.Median(nums));
            Assert.Throws<Exception>(() => ArrayUtilities.Mode(nums)); //nums has no mode so it should cry like a baby
            Assert.Equal(new double[] { 2, 2, 3, 0, 3, 4 }, ArrayUtilities.AddToAll(nums, 1));

            Assert.Equal(new double[] { 1, 1, 2, -1, 2, 3, 5 }, ArrayUtilities.Append(nums, 5));
            Assert.Equal(new double[] { 1, 1, 2, 2, 3 }, ArrayUtilities.Remove(nums, 3));

            Assert.Equal(true, ArrayUtilities.Contains(nums, 3)); //test both cases
            Assert.Equal(false, ArrayUtilities.Contains(nums, 69));

            Assert.Equal(3, ArrayUtilities.IndexOf(nums, -1));
            Assert.Equal(2, ArrayUtilities.HowMany(nums, 2));
        }

        {
            decimal[] nums = { 1, 1, 2, -1, 2, 3 };

            Assert.Equal(8.0m / 6, ArrayUtilities.Average(nums));
            Assert.Equal(3, ArrayUtilities.Max(nums));
            Assert.Equal(-1, ArrayUtilities.Min(nums));

            Assert.Equal(new decimal[] { -1, 1, 1, 2, 2, 3 }, ArrayUtilities.SortAscending(nums));
            Assert.Equal(new decimal[] { 3, 2, 2, 1, 1, -1 }, ArrayUtilities.SortDescending(nums));

            Assert.Equal(8, ArrayUtilities.Sum(nums));
            Assert.Equal(-12, ArrayUtilities.Product(nums));

            Assert.Equal(new decimal[] { 3, 2, -1, 2, 1, 1 }, ArrayUtilities.Reverse(nums));

            Assert.Equal(1.5m, ArrayUtilities.Median(nums));
            Assert.Throws<Exception>(() => ArrayUtilities.Mode(nums)); //nums has no mode so it should cry like a baby
            Assert.Equal(new decimal[] { 2, 2, 3, 0, 3, 4 }, ArrayUtilities.AddToAll(nums, 1));

            Assert.Equal(new decimal[] { 1, 1, 2, -1, 2, 3, 5 }, ArrayUtilities.Append(nums, 5));
            Assert.Equal(new decimal[] { 1, 1, 2, 2, 3 }, ArrayUtilities.Remove(nums, 3));

            Assert.Equal(true, ArrayUtilities.Contains(nums, 3)); //test both cases
            Assert.Equal(false, ArrayUtilities.Contains(nums, 69));

            Assert.Equal(3, ArrayUtilities.IndexOf(nums, -1));
            Assert.Equal(2, ArrayUtilities.HowMany(nums, 2));
        }

        { //make sure things explode properly
            int[] nums = { };

            Assert.Throws<FormatException>(() => ArrayUtilities.Average(nums));
            Assert.Throws<FormatException>(() => ArrayUtilities.Max(nums));
            Assert.Throws<FormatException>(() => ArrayUtilities.Min(nums));

            Assert.Throws<FormatException>(() => ArrayUtilities.Sum(nums));
            Assert.Throws<FormatException>(() => ArrayUtilities.Product(nums));

            Assert.Throws<FormatException>(() => ArrayUtilities.Reverse(nums));

            Assert.Throws<FormatException>(() => ArrayUtilities.Median(nums));
            Assert.Throws<FormatException>(() => ArrayUtilities.Mode(nums));
        }
    }


    [Fact]
    public void MathTests() {
        Assert.Equal(243, MathUtilities.Power(3, 5));
        Assert.Equal(1.7320508100147274, MathUtilities.SquareRoot(3));
        Assert.Equal(5, MathUtilities.AbsoluteValue(-5));

        Assert.Equal(6, MathUtilities.Min(6, 9));
        Assert.Equal(9, MathUtilities.Max(6, 9));

        Assert.Equal(19, MathUtilities.Add(9, 10));
        Assert.Equal(-1, MathUtilities.Subtract(9, 10));
        Assert.Equal(90, MathUtilities.Multiply(9, 10));
        Assert.Equal(0.9, MathUtilities.Divide(9, 10));
        Assert.Equal(90, MathUtilities.Percentage(9, 10));

        Assert.Equal("10000", MathUtilities.Binary(9));

        Assert.Equal(100, MathUtilities.round(100.2));
        Assert.Equal(100, MathUtilities.Floor(100.2));
        Assert.Equal(101, MathUtilities.ceiling(100.2));

    }
}