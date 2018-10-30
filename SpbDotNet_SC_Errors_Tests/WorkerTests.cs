using System;
using SpbDotNet_SC_Errors;
using Xunit;

namespace SpbDotNet_SC_Errors_Tests
{
    public class WorkerTests
    {
        private readonly Worker _worker = new Worker();

        [Fact]
        public void GetCountSum_Test()
        {
            var a = new TrackedEntity {Count = 5};
            var b = new UnTrackedEntity { Count = 15 };

            var result = _worker.GetCountsSum(a, b);
            Assert.True(result == a.Count + b.Count);
        }
    }
}
