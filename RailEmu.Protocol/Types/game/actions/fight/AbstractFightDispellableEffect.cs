
















// Generated on 10/13/2017 02:17:21
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class AbstractFightDispellableEffect
{

public const short Id = 206;
public virtual short TypeId
{
    get { return Id; }
}

public int uid;
        public int targetId;
        public short turnDuration;
        public sbyte dispelable;
        public short spellId;
        

public AbstractFightDispellableEffect()
{
}

public AbstractFightDispellableEffect(int uid, int targetId, short turnDuration, sbyte dispelable, short spellId)
        {
            this.uid = uid;
            this.targetId = targetId;
            this.turnDuration = turnDuration;
            this.dispelable = dispelable;
            this.spellId = spellId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(uid);
            writer.WriteInt(targetId);
            writer.WriteShort(turnDuration);
            writer.WriteSByte(dispelable);
            writer.WriteShort(spellId);
            

}

public virtual void Deserialize(IDataReader reader)
{

uid = reader.ReadInt();
            if (uid < 0)
                throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
            targetId = reader.ReadInt();
            turnDuration = reader.ReadShort();
            dispelable = reader.ReadSByte();
            if (dispelable < 0)
                throw new Exception("Forbidden value on dispelable = " + dispelable + ", it doesn't respect the following condition : dispelable < 0");
            spellId = reader.ReadShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}



}


}
