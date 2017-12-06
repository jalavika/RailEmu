
















// Generated on 10/13/2017 02:17:27
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class PrismConquestInformation
{

public const short Id = 152;
public virtual short TypeId
{
    get { return Id; }
}

public bool isEntered;
        public bool isInRoom;
        public int subId;
        public sbyte alignment;
        

public PrismConquestInformation()
{
}

public PrismConquestInformation(bool isEntered, bool isInRoom, int subId, sbyte alignment)
        {
            this.isEntered = isEntered;
            this.isInRoom = isInRoom;
            this.subId = subId;
            this.alignment = alignment;
        }
        

public virtual void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, isEntered);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isInRoom);
            writer.WriteByte(flag1);
            writer.WriteInt(subId);
            writer.WriteSByte(alignment);
            

}

public virtual void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            isEntered = BooleanByteWrapper.GetFlag(flag1, 0);
            isInRoom = BooleanByteWrapper.GetFlag(flag1, 1);
            subId = reader.ReadInt();
            if (subId < 0)
                throw new Exception("Forbidden value on subId = " + subId + ", it doesn't respect the following condition : subId < 0");
            alignment = reader.ReadSByte();
            if (alignment < 0)
                throw new Exception("Forbidden value on alignment = " + alignment + ", it doesn't respect the following condition : alignment < 0");
            

}



}


}
