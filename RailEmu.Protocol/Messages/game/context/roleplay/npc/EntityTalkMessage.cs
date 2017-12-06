
















// Generated on 10/13/2017 02:18:51
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class EntityTalkMessage : Message
{

public const uint Id = 6110;
public override uint MessageId
{
    get { return Id; }
}

public int entityId;
        public short textId;
        public IEnumerable<string> parameters;
        

public EntityTalkMessage()
{
}

public EntityTalkMessage(int entityId, short textId, IEnumerable<string> parameters)
        {
            this.entityId = entityId;
            this.textId = textId;
            this.parameters = parameters;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(entityId);
            writer.WriteShort(textId);
            var parameters_before = writer.Position;
            var parameters_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
                 parameters_count++;
            }
            var parameters_after = writer.Position;
            writer.Seek((int)parameters_before);
            writer.WriteUShort((ushort)parameters_count);
            writer.Seek((int)parameters_after);

            

}

public override void Deserialize(IDataReader reader)
{

entityId = reader.ReadInt();
            textId = reader.ReadShort();
            if (textId < 0)
                throw new Exception("Forbidden value on textId = " + textId + ", it doesn't respect the following condition : textId < 0");
            var limit = reader.ReadUShort();
            var parameters_ = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters_[i] = reader.ReadUTF();
            }
            parameters = parameters_;
            

}


}


}
