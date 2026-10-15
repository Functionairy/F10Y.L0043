using System;

using F10Y.T0003;


namespace F10Y.L0043.NonWindows
{
    [ValuesMarker]
    public partial interface IExecutableFilePaths
    {
        /// <summary>
        /// <para><value>/usr/local/bin/nextpad++</value> (MacOS and Linux only)</para>
        /// </summary>
        string NextpadPlusPlus => @"/usr/local/bin/nextpad++";
    }
}
