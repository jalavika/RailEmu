
















// Generated on 10/13/2017 02:18:49
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameRolePlayDelayedActionMessage : Message
{

public const uint Id = 6153;
public override uint MessageId
{
    get { return Id; }
}

public sbyte delayTypeId;
        public int delayDuration;
        

public GameRolePlayDelayedActionMessage()
{
}

public GameRolePlayDelayedActionMessage(sbyte delayTypeId, int delayDuration)
        {
            this.delayTypeId = delayTypeId;
            this.delayDuration = delayDuration;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(delayTypeId);
            writer.WriteInt(delayDuration);
            

}

public override void Deserialize(IDataReader reader)
{

delayTypeId = reader.ReadSByte();
            if (delayTypeId < 0)
                throw new Exception("Forbidden value on delayTypeId = " + delayTypeId + ", it doesn't respect the following condition : delayTypeId < 0");
            delayDuration = reader.ReadInt();
            if (delayDuration < 0)
                throw new Exception("Forbidden value on delayDuration = " + delayDuration + ", it doesn't respect the following condition : delayDuration < 0");
            

}


}


}
