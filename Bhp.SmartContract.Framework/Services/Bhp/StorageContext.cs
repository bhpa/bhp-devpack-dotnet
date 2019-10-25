namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class StorageContext
    {
        /// <summary>
        /// Returns current StorageContext as ReadOnly
        /// </summary>
        public extern StorageContext AsReadOnly
        {
            [Syscall("System.StorageContext.AsReadOnly")]
            get;
        }
    }
}
