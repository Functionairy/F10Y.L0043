using System;


namespace F10Y.L0043
{
    public class ExecutableFilePaths : IExecutableFilePaths
    {
        #region Infrastructure

        public static IExecutableFilePaths Instance { get; } = new ExecutableFilePaths();


        private ExecutableFilePaths()
        {
        }

        #endregion
    }
}


namespace F10Y.L0043.Dynamic
{
    public class ExecutableFilePaths : IExecutableFilePaths
    {
        #region Infrastructure

        public static IExecutableFilePaths Instance { get; } = new ExecutableFilePaths();


        private ExecutableFilePaths()
        {
        }

        #endregion
    }
}


namespace F10Y.L0043.NonWindows
{
    public class ExecutableFilePaths : IExecutableFilePaths
    {
        #region Infrastructure

        public static IExecutableFilePaths Instance { get; } = new ExecutableFilePaths();


        private ExecutableFilePaths()
        {
        }

        #endregion
    }
}