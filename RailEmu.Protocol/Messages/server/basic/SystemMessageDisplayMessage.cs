
















// Generated on 10/13/2017 02:19:07
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class SystemMessageDisplayMessage : Message
{

public const uint Id = 189;
public override uint MessageId
{
    get { return Id; }
}

public bool hangUp;
        public short msgId;
        public IEnumerable<string> parameters;
        

public SystemMessageDisplayMessage()
{
}

public SystemMessageDisplayMessage(bool hangUp, short msgId, IEnumerable<string> parameters)
        {
            this.hangUp = hangUp;
            this.msgId = msgId;
            this.parameters = parameters;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(hangUp);
            writer.WriteShort(msgId);
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

hangUp = reader.ReadBoolean();
            msgId = reader.ReadShort();
            if (msgId < 0)
                throw new Exception("Forbidden value on msgId = " + msgId + ", it doesn't respect the following condition : msgId < 0");
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
