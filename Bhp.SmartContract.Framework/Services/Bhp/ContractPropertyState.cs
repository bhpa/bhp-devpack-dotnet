namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public enum ContractPropertyState : byte
    {
        NoProperty = 0,

        HasStorage = 1 << 0,
        Payable = 1 << 2
    }
}
