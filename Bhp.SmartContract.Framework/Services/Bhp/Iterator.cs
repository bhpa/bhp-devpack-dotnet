namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Iterator<TKey, TValue>
    {
        [Syscall("Bhp.Enumerator.Next")]
        public extern bool Next();

        public extern TKey Key
        {
            [Syscall("Bhp.Iterator.Key")]
            get;
        }

        public extern TValue Value
        {
            [Syscall("Bhp.Enumerator.Value")]
            get;
        }
    }
}
