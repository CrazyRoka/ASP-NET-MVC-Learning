using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLearning.Services
{
    public interface ISampleService
    {
        IEnumerable<String> GetSampleStrings(); 
    }
}
