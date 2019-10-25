namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Transaction
    {
        public readonly byte[] Hash;
        public readonly byte Version;
        public readonly uint Nonce;
        public readonly byte[] Sender;
        public readonly long SystemFee;
        public readonly long NetworkFee;
        public readonly uint ValidUntilBlock;
        public readonly byte[] Script;
    }
}
