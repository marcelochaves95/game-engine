namespace Sesamo.Operators.Comparisons
{
    public class Bigger : Comparison, IOperator
    {
        #region IOperador Members

        private string _cadeia = ">";
        public override Chain Chain
        {
            get { return new Chain(_cadeia); }
        }

        #endregion

        public Bigger()
        {
        }

        public Bigger(int NumeroLinha)
        {
            this.Linha = NumeroLinha;
        }
    }
}