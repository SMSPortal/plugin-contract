namespace HuffmanPluginContract
{
    public interface IHuffmanPlugin
    {
        byte[] Compress(string data, out string tree);
        string Decompress(byte[] data, string tree);
    }
}
