using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLearning.Services
{
    public class SampleService : ISampleService
    {
        public IEnumerable<string> GetSampleStrings() => new[] { "one", "two", "Roka", "Toch" };
    }
}
