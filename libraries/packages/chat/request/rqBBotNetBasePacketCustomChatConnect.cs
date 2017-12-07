using System.IO;
using System.Text;


namespace Libraries.packages.chat
{

    /// <summary>
    /// Reads content packet PacketBBotNetBasePacketCustomChatConnect.
    /// </summary>
    public class PacketBBotNetBasePacketCustomChatConnect
    {

        public byte Counter { get; }

        public string PlayerName { get; }

        public PacketBBotNetBasePacketCustomChatConnect(byte[] request)
        {

            using (MemoryStream Stream = new MemoryStream(request))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    Counter = Reader.ReadByte();

                    int PlayerNameLength = Reader.ReadInt32();

                    PlayerName = Encoding.Unicode.GetString(Reader.ReadBytes(PlayerNameLength));

                }

            }

        }

        public sealed override string ToString()
        {

            return string.Format(
                "PacketBBotNetBasePacketCustomChatConnect\r\n" +
                "Counter\r\n" +
                "PlayerName = {0}\r\n",
                Counter,
                PlayerName
            );

        }

    }

}
