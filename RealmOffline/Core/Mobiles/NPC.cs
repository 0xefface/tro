using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Packets;
using RealmOffline.Core.Items.Base;
using RealmOffline.Core.Rooms;
using RealmOffline.Core.Mobiles;
using RealmOffline.Core;

namespace RealmOffline
{
    public class NPC : Mobile
    {
        static Logs.RLog log = new Logs.RLog();
        public Brain NPCBrain { get; set; }
        public byte RaceHead { get; set; }
        public byte HeadPart { get; set; }
        public byte ChinPart { get; set; }
        public byte HairPart { get; set; }
        public byte EyeBrowPart { get; set; }
        public byte EyePart { get; set; }
        public byte NosePart { get; set; }
        public byte EarPart { get; set; }
        public byte MouthPart { get; set; }
        public byte FacialHairPart { get; set; }
        public byte SkinColor { get; set; }
        public byte HairColor { get; set; }
        public byte EyeColor { get; set; }
        public uint InventoryId = 0;
        public NPCFace Face { get; set; }
        private List<BaseGameItem> inventory;
        public List<BaseGameItem> Inventory
        {
            get
            {
                if (inventory == null) inventory = new List<BaseGameItem>();
                return inventory;
            }
            set { inventory = value; }
        }
        
        public override byte[] AppearInRoom()
        {

            PacketWriter n = new PacketWriter();
            n.WriteByte(0x01);
            n.WriteUShort(this.GraphicID);
            n.WriteUInt32(this.GameID);
            // try 1 byte here
            n.WriteUShort(0x00);
            //n.WriteByte(0x00);
            n.WriteByte(0xFF);
            n.WriteBytes(new byte[] { 0x00, 0x0C, 0x08 });
            n.WriteByte(this.Girth);
            n.WriteByte(this.Height);
            n.WriteByte(0x00);
            n.WriteByte(0x00);
            n.WriteByte(this.Gender);
            if (!string.IsNullOrEmpty(this.Name)) n.WriteString(this.Name);
            else n.WriteShort(0x00); //defaultname

            n.WriteByte(0x01); // 0 here allows fight
            n.WriteInt32(this.CurrentHitPoints);
            n.WriteInt32(this.MaxHitPoints);

            if (this.Location.CurrentRoom.RoomID <= 65534)
            {
                n.WriteByte(0x01);
                n.WriteShort((short)this.Location.CurrentRoom.RoomID);
            }
            else
            {
                n.WriteByte(0x02);
                n.WriteUInt32(this.Location.CurrentRoom.RoomID);
            }
            n.WriteUShort(this.Location.X);
            n.WriteUShort(this.Location.Y);
            n.WriteUShort(this.Location.Facing);
            //n.WriteUShort(0xFF);
            n.WriteShort((short)(this.Inventory.Count + 1));

            
            // inv
            n.WriteByte(0x01);
            n.WriteShort(0x04);
            n.WriteUInt32(ServerGlobals.GetNextAvailableID());
            n.WriteUShort(0x00);
            n.WriteByte(0x00);
            n.WriteByte(0xFF);
            n.WriteUShort(0x00);
            n.WriteByte(0x00);
            //n.WriteByte(0x00);

            

            // parts
            n.WriteByte(this.Face.RaceHead);
            n.WriteByte(this.Face.Gender);
            n.WriteByte(this.Face.ChinPart);
            n.WriteByte(this.Face.HairPart);
            n.WriteByte(this.Face.EyeBrowPart);
            n.WriteByte(this.Face.EyePart);
            n.WriteByte(this.Face.NosePart);
            n.WriteByte(this.Face.EarPart);
            n.WriteByte(this.Face.MouthPart);
            n.WriteByte(this.Face.FacialHairPart);
            n.WriteByte(this.Face.SkinColor);
            n.WriteByte(this.Face.HairColor);
            n.WriteByte(this.Face.EyeColor);

            // 6
            n.WriteByte(0x00);
            n.WriteByte(0x00);
            n.WriteByte(0x00);
            n.WriteByte(0x00);
            n.WriteByte(0x00);
            n.WriteByte(0x00);
            foreach (BaseGameItem b in this.Inventory)
                n.WriteBytes(b.Serialize());
            // 2
            n.WriteByte(0x00);
            n.WriteByte(0x00);
            // need this ?
            //n.WriteByte(0x00);
            //1 
            n.WriteByte(0x01);
            // 2
            n.WriteByte(0x00);
            n.WriteByte(0x00);
            //n.WriteByte(0xFF);
            return n.GetRawPacket();

        }
        
        #region Add to room not on load
        public override byte[] Serialize()
        {
            PacketWriter w = new PacketWriter();
            w.WriteByte(0x01);
            w.WriteUShort(this.GraphicID);
            if (this.GameID == 0) this.GameID = ServerGlobals.GetNextAvailableID();
            w.WriteUInt32(this.GameID);
            // Spells
            //w.WriteByte(0x00);
            w.WriteUShort(0x00);
            w.WriteByte(0xFF);
            w.WriteBytes(new byte[] { 0x00, 0x0C, 0x08 });
            w.WriteByte(this.Girth);
            w.WriteByte(this.Height);
            w.WriteByte(0x00); 
            w.WriteByte(0x00);
            w.WriteByte(this.Gender);
            if (!string.IsNullOrEmpty(this.Name)) w.WriteString(this.Name);
            else w.WriteShort(0x00); //defaultname
            //
            w.WriteByte(0x01);
            w.WriteInt32(this.CurrentHitPoints);
            w.WriteInt32(this.MaxHitPoints);

            if (this.Location.CurrentRoom.RoomID <= 65534)
            {
                w.WriteByte(0x01);
                w.WriteShort((short)this.Location.CurrentRoom.RoomID);
            }
            else
            {
                w.WriteByte(0x02);
                w.WriteUInt32(this.Location.CurrentRoom.RoomID);
            }
            w.WriteUShort(this.Location.X);
            w.WriteUShort(this.Location.Y);
            w.WriteUShort(this.Location.Facing);
            //w.WriteUShort(0x02);
            // Ok inventory ?
            w.WriteShort((short)(this.Inventory.Count +1));

            

            w.WriteByte(0x01);
            w.WriteShort(0x04);
            this.InventoryId = ServerGlobals.GetNextAvailableID();
            w.WriteUInt32(this.InventoryId);
            w.WriteBytes(new byte[3]);
            w.WriteByte(0xFF); // end


            w.WriteByte(0x00);
            w.WriteByte(0x00);
            w.WriteByte(0x00);
            //w.WriteBytes(new byte[3]);
            // begin Part data


            w.WriteByte(this.RaceHead);
            w.WriteByte(this.Gender);
            w.WriteByte(this.ChinPart);
            w.WriteByte(this.HairPart);
            w.WriteByte(this.EyeBrowPart);
            w.WriteByte(this.EyePart);
            w.WriteByte(this.NosePart);
            w.WriteByte(this.EarPart);
            w.WriteByte(this.MouthPart);
            w.WriteByte(this.FacialHairPart);
            w.WriteByte(this.SkinColor);
            w.WriteByte(this.HairColor);
            w.WriteByte(this.EyeColor);

            w.WriteByte(0x00);// nothing i can see
            w.WriteByte(0x00); // nothing i can see
            w.WriteByte(0x00); // invalid selector for head
            w.WriteByte(0x00); // nothing i can see
            w.WriteByte(0x00); // nothing i can see
            w.WriteByte(0x00); // nada
                               //w.WriteBytes(new byte[6]); // Not sure if these have values, i never see them

            foreach (BaseGameItem item in this.Inventory)
                w.WriteBytes(item.Serialize());

            w.WriteByte(0x00);
            w.WriteByte(0x00); // bad byte, or makes her sit
            w.WriteByte(0x00); // talk switch
            w.WriteByte(0x01); // shows nothing
            w.WriteByte(0x00); // shows nothig
            w.WriteByte(0xFF);
            return w.GetRawPacket();
        }
        #endregion
        /// <summary>
        /// Builds a head/face for a headless npc
        /// </summary>
        /// <param name="race">The race, 0-3</param>
        /// <param name="gender">0=male, 1=female.</param>
        /// <param name="chin"></param>
        /// <param name="hair"></param>
        /// <param name="brow"></param>
        /// <param name="eyes"></param>
        /// <param name="nose"></param>
        /// <param name="ear"></param>
        /// <param name="mouth"></param>
        /// <param name="beard"></param>
        /// <param name="skincolor"></param>
        /// <param name="haircolor"></param>
        /// <param name="eyecolor"></param>
        public void BuildHead(byte race, byte gender, byte chin, byte hair, byte brow,
            byte eyes, byte nose, byte ear, byte mouth, byte beard, byte skincolor, byte haircolor, byte eyecolor)
        {
            this.RaceHead = race;
            this.Gender = gender;
            this.ChinPart = chin;
            this.HairPart = hair;
            this.EyeBrowPart = brow;
            this.EyePart = eyes;
            this.NosePart = nose;
            this.EarPart = ear;
            this.MouthPart = mouth;
            this.FacialHairPart = beard;
            this.SkinColor = skincolor;
            this.HairColor = haircolor;
            this.EyeColor = eyecolor;
            this.CreateFace();
            
        }
        public void CreateFace()
        {
            this.Face = new NPCFace(this.RaceHead, this.Gender, this.ChinPart, this.HairPart, this.EyeBrowPart, this.EyePart, this.NosePart, this.EarPart, this.MouthPart, this.FacialHairPart, this.SkinColor, this.HairColor, this.EyeColor);

        }
        public static NPC NPCFromCode(ushort graphicID, byte girth, byte height, string name,
            int currentHP, int maxHP, uint inRoomNum, ushort locX, ushort locY, ushort facing, NPCFace face, Room room)
        {
            NPC n = new NPC();
            n.Face = face;
            n.GraphicID = graphicID;
            n.GameID = ServerGlobals.GetNextAvailableID();
            // Set up locs n room
            n.Location = new RoomLocation(inRoomNum, locX, locY, facing);
            n.Location.CurrentRoom = room;
            // Continue
            n.Girth = girth;
            n.Height = height;
            n.Name = name;
            n.CurrentHitPoints = currentHP;
            n.MaxHitPoints = maxHP;
            n.RaceHead = face.RaceHead;
            n.Gender = face.Gender;
            n.ChinPart = face.ChinPart;
            n.HairPart = face.HairPart;
            n.EyeBrowPart = face.EyeBrowPart;
            n.EyePart = face.EyePart;
            n.NosePart = face.NosePart;
            n.EarPart = face.EarPart;
            n.MouthPart = face.MouthPart;
            n.FacialHairPart = face.FacialHairPart;
            n.SkinColor = face.SkinColor;
            n.HairColor = face.HairColor;
            n.EyeColor = face.EyeColor;
            n.Inventory = BasicInventory();
            return n;
        }
        private static List<BaseGameItem> BasicInventory()
        {
            List<BaseGameItem> defaultInventory = new List<BaseGameItem>();
            Item i1 = new Item();
            i1.GameID = ServerGlobals.GetNextAvailableID();
            i1.Equipped = true;
            i1.Color = 99;
            i1.GraphicID = 1155;
            defaultInventory.Add(i1);
            i1 = new Item();
            i1.GameID = ServerGlobals.GetNextAvailableID();
            i1.Equipped = true;
            i1.Color = 99;
            i1.GraphicID = 1191;
            defaultInventory.Add(i1);
            return defaultInventory;
        }
    }
}
public class NPCFace
{
    // 13
    public byte RaceHead;
    public byte Gender;
    public byte ChinPart;
    public byte HairPart;
    public byte EyeBrowPart;
    public byte EyePart;
    public byte NosePart;
    public byte EarPart;
    public byte MouthPart;
    public byte FacialHairPart;
    public byte SkinColor;
    public byte HairColor;
    public byte EyeColor;

    public NPCFace(byte race, byte gender, byte chin, byte hair, byte brow, byte eyes,
        byte nose, byte ear, byte mouth, byte beard, byte skinColor, byte hairColor, byte eyeColor)
    {
        this.RaceHead = race;
        this.Gender = gender;
        this.ChinPart = chin;
        this.HairPart = hair;
        this.EyeBrowPart = brow;
        this.EyePart = eyes;
        this.NosePart = nose;
        this.EarPart = ear;
        this.MouthPart = mouth;
        this.FacialHairPart = beard;
        this.SkinColor = skinColor;
        this.HairColor = hairColor;
        this.EyeColor = eyeColor;
    }
}