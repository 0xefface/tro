﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core;

namespace Scripts.Scripts.Commands
{
    [RequiredPrivledge(PrivLevel.Player)]
    public class List : Command
    {
        public override char CommandPrefix
        {
            get { return '/'; }
        }
        public override string CommandName
        {
            get { return "List"; }
        }
        public override void ReactToPacket()
        {
            byte[] chan = { 0xE2, 0x00, 0x00, 0x00, 
0x3D, 0x00, 0x00, 0x00, 
0x93, 0x62, 
0x02, 0x00, 
0x00, 0x00, 0x00, 0x00, 
0x00, 
0x06, 0x00, 
0x00, 0x00, 0x01, 0x00, 0x30, 
0x07, 0x00, 
0x4E, 0x65, 0x77, 0x62, 0x69, 0x65, 0x73, 
0x03, 0x00, 0x79, 0x65, 0x73, 
0x09, 0x00, 0x54, 0x68, 0x65, 0x20, 0x52, 0x65, 0x61, 0x6C, 0x6D, 

0x03, 0x00, 0x32, 0x35, 0x35,
//0x01, 0x00, 0x30, 
// 0x32 0x35 0x35 
0x01, 0x00, 0x31, 0x07, 0x00, 0x47, 0x65, 0x6E, 0x65, 0x72, 0x61, 0x6C, 0x03, 0x00, 0x79, 0x65, 0x73, 0x09, 0x00, 0x54, 0x68, 0x65, 0x20, 0x52, 0x65, 0x61, 0x6C, 0x6D, 0x01, 0x00, 0x30, 0x01, 0x00, 0x32, 0x0B, 0x00, 0x42, 0x61, 0x72, 0x64, 0x27, 0x73, 0x20, 0x54, 0x75, 0x6E, 0x65, 0x03, 0x00, 0x79, 0x65, 0x73, 0x09, 0x00, 0x54, 0x68, 0x65, 0x20, 0x52, 0x65, 0x61, 0x6C, 0x6D, 0x01, 0x00, 0x30, 0x01, 0x00, 0x33, 0x11, 0x00, 0x54, 0x68, 0x65, 0x20, 0x4D, 0x65, 0x65, 0x74, 0x69, 0x6E, 0x67, 0x20, 0x50, 0x6C, 0x61, 0x63, 0x65, 0x03, 0x00, 0x79, 0x65, 0x73, 0x09, 0x00, 0x54, 0x68, 0x65, 0x20, 0x52, 0x65, 0x61, 0x6C, 0x6D, 0x01, 0x00, 0x30, 0x01, 0x00, 0x34, 0x09, 0x00, 0x47, 0x61, 0x6D, 0x65, 0x20, 0x48, 0x65, 0x6C, 0x70, 0x03, 0x00, 0x79, 0x65, 0x73, 0x09, 0x00, 0x54, 0x68, 0x65, 0x20, 0x52, 0x65, 0x61, 0x6C, 0x6D, 

0x01, 0x00, 0x31, 0x01, 0x00, 0x35, 
0x07, 0x00, 0x54, 0x72, 0x61, 0x64, 0x69, 0x6E, 0x67, 0x03, 0x00, 0x79, 0x65, 0x73, 0x09, 0x00, 0x54, 0x68, 0x65, 0x20, 0x52, 0x65, 0x61, 0x6C, 0x6D, 0x01, 0x00, 0x30, 0x00, 0x00, 0x78, 0x74, 0x65, 0xAF, 0x3C, 0x8D, 0x38 };
            Player.Socket.Send(ref chan);
        }
    }
}