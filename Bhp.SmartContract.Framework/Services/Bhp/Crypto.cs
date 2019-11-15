namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public static class Crypto
    {
        [Syscall("Bhp.Crypto.ECDsaVerify")]
        public extern static bool ECDsaVerify(byte[] message, byte[] pubkey, byte[] signature);

        [Syscall("Bhp.Crypto.ECDsaCheckMultiSig")]
        public extern static bool ECDsaCheckMultiSig(byte[] message, byte[][] pubkey, byte[][] signature);
    }
}
