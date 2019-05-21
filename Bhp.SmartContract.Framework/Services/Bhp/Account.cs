namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Account
    {
        [Syscall("Bhp.Account.IsStandard")]
        public static extern bool IsStandard(byte[] scripthash);
    }
}
