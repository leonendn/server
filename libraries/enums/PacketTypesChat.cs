namespace Libraries.enums
{

    public enum PacketTypesChat
    {
        
        BBotNetBasePacketCustomChatJoinChannelRequest = 0,
        BBotNetBasePacketCustomChatJoinChannelEvent = 1,
        BBotNetBasePacketCustomChatLeaveChannelRequest = 2,
        BBotNetBasePacketCustomChatLeaveChannelEvent = 3,
        BBotNetBasePacketCustomChatMessage = 4,
        eChatReceivedEvent = 5,
        BBotNetBasePacketCustomChatWhisper = 6,
        eWhisperRecievedEvent = 7,
        BBotNetBasePacketCustomChatPopCountRequest = 8,
        BBotNetBasePacketCustomChatPopCountEvent = 9,
        BBotNetBasePacketCustomRequestLeaveServer = 10,
        BBotNetBasePacketCustomChatConnect = 11,
        BBotNetBasePacketCustomChatNonexistantHandleEvent = 12,
        BBotNetBasePacketCustomChatWhisperResponse = 13,
        BBotNetBasePacketChatData = 14,
        BBotNetBasePacketDirectChatData = 15,
        EServerAnnouncement = 16,
        BBotNetBasePacketReportChat = 17,
        unknown = 21,        
        BBotNetBasePacketCustomChatPing = 254,
        BBotNetBasePacketCustomChatPong = 255

    }

}
