using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Replay
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public byte Gameid { get; set; }
        public uint Roomid { get; set; }
        public byte Format { get; set; }
        public ulong Player0 { get; set; }
        public ulong Player1 { get; set; }
        public ulong Player2 { get; set; }
        public ulong Player3 { get; set; }
        public byte[]? Data { get; set; }
    }
}
