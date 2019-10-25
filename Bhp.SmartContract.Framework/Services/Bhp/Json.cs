namespace Bhp.SmartContract.Framework.Services.Bhp
{
    public static class Json
    {
        [Syscall("Bhp.Json.Serialize")]
        public extern static string Serialize(object obj);

        [Syscall("Bhp.Json.Deserialize")]
        public extern static object Deserialize(string json);
    }
}
