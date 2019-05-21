namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Header : IScriptContainer
    {
        public extern byte[] Hash
        {
            [Syscall("System.Header.GetHash")]
            get;
        }

        public extern uint Version
        {
            [Syscall("Bhp.Header.GetVersion")]
            get;
        }

        public extern byte[] PrevHash
        {
            [Syscall("System.Header.GetPrevHash")]
            get;
        }

        public extern byte[] MerkleRoot
        {
            [Syscall("Bhp.Header.GetMerkleRoot")]
            get;
        }

        public extern uint Timestamp
        {
            [Syscall("System.Header.GetTimestamp")]
            get;
        }

        public extern uint Index
        {
            [Syscall("System.Header.GetIndex")]
            get;
        }

        public extern byte[] NextConsensus
        {
            [Syscall("Bhp.Header.GetNextConsensus")]
            get;
        }
    }
}
