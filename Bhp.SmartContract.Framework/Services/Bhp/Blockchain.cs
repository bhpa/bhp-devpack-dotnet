namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public static class Blockchain
    {
        [Syscall("Bhp.Blockchain.GetHeight")]
        public static extern uint GetHeight();

        [Syscall("Bhp.Blockchain.GetHeader")]
        public static extern Header GetHeader(uint height);

        [Syscall("Bhp.Blockchain.GetHeader")]
        public static extern Header GetHeader(byte[] hash);

        [Syscall("Bhp.Blockchain.GetBlock")]
        public static extern Block GetBlock(uint height);

        [Syscall("Bhp.Blockchain.GetBlock")]
        public static extern Block GetBlock(byte[] hash);

        [Syscall("Bhp.Blockchain.GetTransaction")]
        public static extern Transaction GetTransaction(byte[] hash);
        
        [Syscall("Bhp.Blockchain.GetContract")]
        public static extern Contract GetContract(byte[] script_hash);
    }
}
