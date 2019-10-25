using System;

namespace Bhp.SmartContract.Framework.Services.Bhp
{
    [Flags]
    public enum StorageFlags : byte
    {
        None = 0x00,
        Constant = 0x01
    }
}
