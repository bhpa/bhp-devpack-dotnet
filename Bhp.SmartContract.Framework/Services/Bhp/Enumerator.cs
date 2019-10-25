using System.Collections.Generic;

namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public class Enumerator<TValue>
    {
        [Syscall("Bhp.Enumerator.Create")]
        public static extern Enumerator<TValue> Create(IEnumerable<TValue> entry);

        [Syscall("Bhp.Enumerator.Concat")]
        public extern Enumerator<TValue> Concat(Enumerator<TValue> value);

        [Syscall("Bhp.Enumerator.Next")]
        public extern bool Next();

        public extern TValue Value
        {
            [Syscall("Bhp.Enumerator.Value")]
            get;
        }
    }
}
