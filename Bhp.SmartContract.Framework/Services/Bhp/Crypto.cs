namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public static class Crypto
    {
        [Syscall("Bhp.Crypto.CheckSig")]
        public extern static bool VerifySignature(byte[] pubkey, byte[] signature);

        [Syscall("System.Crypto.Verify")]
        public extern static bool VerifySignature(byte[] message, byte[] pubkey, byte[] signature);

        [Syscall("Bhp.Crypto.CheckMultiSig")]
        public extern static bool VerifySignatures(byte[][] pubkey, byte[][] signature);
    }
}
