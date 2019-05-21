namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Contract
    {
        public extern byte[] Script
        {
            [Syscall("Bhp.Contract.GetScript")]
            get;
        }
       
        public extern bool IsPayable
        {
            [Syscall("Bhp.Contract.IsPayable")]
            get;
        }
        
        [Syscall("Bhp.Contract.Create")]
        public static extern Contract Create(byte[] script, ContractPropertyState contract_property_state);

        [Syscall("Bhp.Contract.Migrate")]
        public static extern Contract Migrate(byte[] script, ContractPropertyState contract_property_state);

        [Syscall("System.Contract.Destroy")]
        public static extern void Destroy();
    }
}
