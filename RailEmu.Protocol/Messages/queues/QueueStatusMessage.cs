
















// Generated on 10/13/2017 02:19:07
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class QueueStatusMessage : Message
{

public const uint Id = 6100;
public override uint MessageId
{
    get { return Id; }
}

public ushort position;
        public ushort total;
        

public QueueStatusMessage()
{
}

public QueueStatusMessage(ushort position, ushort total)
        {
            this.position = position;
            this.total = total;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUShort(position);
            writer.WriteUShort(total);
            

}

public override void Deserialize(IDataReader reader)
{

position = reader.ReadUShort();
            if (position < 0 || position > 65535)
                throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 65535");
            total = reader.ReadUShort();
            if (total < 0 || total > 65535)
                throw new Exception("Forbidden value on total = " + total + ", it doesn't respect the following condition : total < 0 || total > 65535");
            

}


}


}
