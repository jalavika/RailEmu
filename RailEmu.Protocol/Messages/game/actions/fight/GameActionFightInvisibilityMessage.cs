
















// Generated on 10/13/2017 02:18:39
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameActionFightInvisibilityMessage : AbstractGameActionMessage
{

public const uint Id = 5821;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public sbyte state;
        

public GameActionFightInvisibilityMessage()
{
}

public GameActionFightInvisibilityMessage(short actionId, int sourceId, int targetId, sbyte state)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.state = state;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteSByte(state);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            state = reader.ReadSByte();
            

}


}


}
