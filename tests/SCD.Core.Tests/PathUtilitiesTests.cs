using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using SCD.Core.Utilities;

namespace SCD.Core.Tests;

public class PathUtilitiesTests
{
    [TestCase("\\/:*?\"<>|")]
    public void NormalizePath_RemovesAllInvalidChars(string url)
    {
        string result = PathUtilities.NormalizePath(url);

        Assert.IsEmpty(result);
    }
}
