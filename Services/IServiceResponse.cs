using System;
using System.Collections.Generic;

namespace Services
{
    public interface IServiceResponse<T>
    {
        IList<T> List { get; set; }
        T Entity { get; set; }

        int Count { get; set; }

        bool IsSuccessful { get; set; }
    }
}
