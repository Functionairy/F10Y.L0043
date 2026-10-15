using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0043.Dynamic
{
    [ValuesMarker]
    public partial interface IExecutableFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private static NonWindows.IExecutableFilePaths _NonWindows => NonWindows.ExecutableFilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Chosen based on operating system:
        /// <list type="bullet">
        /// <item>NotImplementedException</item>
        /// <item><value>/usr/local/bin/nextpad++</value></item>
        /// <item>NotImplementedException</item>
        /// </list>
        /// </summary>
        string NextpadPlusPlus => Instances.OperatingSystemOperator.SwitchOn_OSPlatform(
            () => throw new NotImplementedException(),
            () => _NonWindows.NextpadPlusPlus,
            () => throw new NotImplementedException()
        );
    }
}
