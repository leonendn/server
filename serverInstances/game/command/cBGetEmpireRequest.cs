﻿using System.IO;
using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.game;
using Libraries.helpers.pathing;
using Libraries.enums;


namespace Game.Command
{

    public class BGetEmpireRequest : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBGetEmpireRequest Request = new PacketBGetEmpireRequest(p.Content);

            if (s.Logger.IsDebugEnabled)
            {

                s.Logger.Debug($"Execute command: {Request}");

            }

            string Content = File.ReadAllText($"{PathingHelper.tmpDir}BEmpireResponse.xml");

            PacketBGetEmpireResponse ResponseContent = new PacketBGetEmpireResponse(Request.Xuid, Content);

            if (s.Logger.IsDebugEnabled)
                s.Logger.Debug($"Command response: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, (byte) PacketTypes.BGetEmpireResponse, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
