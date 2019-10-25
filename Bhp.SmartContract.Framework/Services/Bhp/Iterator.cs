using System.Collections.Generic;

namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Iterator<TKey, TValue>
    {
        [Syscall("Bhp.Iterator.Create")]
        public static extern Iterator<TKey, TValue> Create(Map<TKey, TValue> entry);

        [Syscall("Bhp.Iterator.Create")]
        public static extern Iterator<TKey, TValue> Create(IEnumerable<TValue> entry);

        [Syscall("Bhp.Iterator.Concat")]
        public extern Iterator<TKey, TValue> Concat(Iterator<TKey, TValue> value);

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

        public extern Enumerator<TKey> Keys
        {
            [Syscall("Bhp.Iterator.Keys")]
            get;
        }

        public extern Enumerator<TValue> Values
        {
            [Syscall("Bhp.Iterator.Values")]
            get;
        }
    }
}
