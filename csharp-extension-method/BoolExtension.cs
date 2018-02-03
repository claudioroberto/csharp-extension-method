using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_extension_method
{
    public static class BoolExtension
    {
        public static bool IsValid(this bool? value)
        {
            return (value.HasValue && value.Value);
        }
    }
}
