namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Transaction : IScriptContainer
    {
        public extern byte[] Hash
        {
            [Syscall("System.Transaction.GetHash")]
            get;
        }

        public extern byte[] Script
        {
            [Syscall("Bhp.Transaction.GetScript")]
            get;
        }

        [Syscall("Bhp.Transaction.GetAttributes")]
        public extern TransactionAttribute[] GetAttributes();        
    }
}
