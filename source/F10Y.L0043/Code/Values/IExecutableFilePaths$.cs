using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0043
{
    [ValuesMarker]
    public partial interface IExecutableFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        Dynamic.IExecutableFilePaths _Dynamic => Dynamic.ExecutableFilePaths.Instance;

        [Ignore]
        NonWindows.IExecutableFilePaths _NonWindows => NonWindows.ExecutableFilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Dynamic.IExecutableFilePaths.NextpadPlusPlus"/>
        string NextpadPlusPlus => _Dynamic.NextpadPlusPlus;
    }
}
