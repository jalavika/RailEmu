
















// Generated on 10/13/2017 02:18:45
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameMapMovementMessage : Message
{

public const uint Id = 951;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<short> keyMovements;
        public int actorId;
        

public GameMapMovementMessage()
{
}

public GameMapMovementMessage(IEnumerable<short> keyMovements, int actorId)
        {
            this.keyMovements = keyMovements;
            this.actorId = actorId;
        }
        

public override void Serialize(IDataWriter writer)
{

var keyMovements_before = writer.Position;
            var keyMovements_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
                 keyMovements_count++;
            }
            var keyMovements_after = writer.Position;
            writer.Seek((int)keyMovements_before);
            writer.WriteUShort((ushort)keyMovements_count);
            writer.Seek((int)keyMovements_after);

            writer.WriteInt(actorId);
            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var keyMovements_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 keyMovements_[i] = reader.ReadShort();
            }
            keyMovements = keyMovements_;
            actorId = reader.ReadInt();
            

}


}


}
