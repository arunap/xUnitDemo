using System.Collections;
using System.Collections.Generic;

namespace xUnitTestDemo.Tests.Mock
{
    public class DivideMethodData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { 1, 1, 1 },
            new object[] { 10, 5, 2 },
            new object[] { 33, 3, 11 },
            new object[] { -50, -5, 10 },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
