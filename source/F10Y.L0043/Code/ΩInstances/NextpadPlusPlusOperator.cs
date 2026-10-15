using System;


namespace F10Y.L0043
{
    public class NextpadPlusPlusOperator : INextpadPlusPlusOperator
    {
        #region Infrastructure

        public static INextpadPlusPlusOperator Instance { get; } = new NextpadPlusPlusOperator();


        private NextpadPlusPlusOperator()
        {
        }

        #endregion
    }
}
