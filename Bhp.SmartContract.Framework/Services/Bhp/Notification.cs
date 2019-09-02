namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Notification : IApiInterface
    {
        /// <summary>
        /// Sender script hash
        /// </summary>
        public readonly byte[] ScriptHash;

        /// <summary>
        /// Notification's state
        /// </summary>
        public readonly object State;
    }
}
