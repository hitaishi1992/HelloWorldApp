﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldUtilities.Wrappers
{
    public interface IUri
    {
        ///     Creates a Uri based on the specified Uri string
        
        /// Returns A DateTime object containing the date and time of Now
        Uri GetUri(string uriString);
    }
}
