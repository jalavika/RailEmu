
















// Generated on 10/13/2017 02:18:41
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class SequenceEndMessage : Message
{

public const uint Id = 956;
public override uint MessageId
{
    get { return Id; }
}

public short actionId;
        public int authorId;
        public sbyte sequenceType;
        

public SequenceEndMessage()
{
}

public SequenceEndMessage(short actionId, int authorId, sbyte sequenceType)
        {
            this.actionId = actionId;
            this.authorId = authorId;
            this.sequenceType = sequenceType;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(actionId);
            writer.WriteInt(authorId);
            writer.WriteSByte(sequenceType);
            

}

public override void Deserialize(IDataReader reader)
{

actionId = reader.ReadShort();
            if (actionId < 0)
                throw new Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            authorId = reader.ReadInt();
            sequenceType = reader.ReadSByte();
            

}


}


}
