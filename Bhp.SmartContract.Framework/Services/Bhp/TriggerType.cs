namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public enum TriggerType : byte
    {
        System = 0x01,
        Verification = 0x20,
        Application = 0x40,
        All = System | Verification | Application
    }
}
