using System;


namespace F10Y.L0043
{
#pragma warning disable IDE1006 // Naming Styles
    public interface Instances :
#pragma warning restore IDE1006 // Naming Styles
        Instances_Internal,
        L0000.Instances_Internal
    {
		
    }


#pragma warning disable IDE1006 // Naming Styles
    public interface Instances_Internal
#pragma warning restore IDE1006 // Naming Styles
    {
        public static IExecutableFilePaths ExecutableFilePaths => L0043.ExecutableFilePaths.Instance;
        public static INextpadPlusPlusOperator NextpadPlusPlusOperator => L0043.NextpadPlusPlusOperator.Instance;
    }
}