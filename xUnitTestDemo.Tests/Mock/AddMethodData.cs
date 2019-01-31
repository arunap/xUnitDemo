using System.Collections;
using System.Collections.Generic;

namespace xUnitTestDemo.Tests.Mock
{
    public class AddMethodData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { 1, 1, 2 },
            new object[] { 10, 11, 21 },
            new object[] { 99, 1, 100 },
            new object[] { -50, -49, -99 },
            new object[] { -5, -10, -15 },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
