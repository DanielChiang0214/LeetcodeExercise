using Xunit.Abstractions;

namespace LeetcodeExerciseTest.Body
{
    public class TestBase
    {
        public ITestOutputHelper Output { get; }
        public TestBase(ITestOutputHelper output)
        {
            Output = output;
        }

        public T Print<T>(T @object)
        {
            Output.WriteLine(@object.ToString());
            return @object;
        }
    }
}