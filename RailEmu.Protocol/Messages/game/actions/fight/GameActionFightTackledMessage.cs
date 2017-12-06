
















// Generated on 10/13/2017 02:18:40
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameActionFightTackledMessage : AbstractGameActionMessage
{

public const uint Id = 1004;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<int> tacklersIds;
        

public GameActionFightTackledMessage()
{
}

public GameActionFightTackledMessage(short actionId, int sourceId, IEnumerable<int> tacklersIds)
         : base(actionId, sourceId)
        {
            this.tacklersIds = tacklersIds;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            var tacklersIds_before = writer.Position;
            var tacklersIds_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in tacklersIds)
            {
                 writer.WriteInt(entry);
                 tacklersIds_count++;
            }
            var tacklersIds_after = writer.Position;
            writer.Seek((int)tacklersIds_before);
            writer.WriteUShort((ushort)tacklersIds_count);
            writer.Seek((int)tacklersIds_after);

            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            var tacklersIds_ = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 tacklersIds_[i] = reader.ReadInt();
            }
            tacklersIds = tacklersIds_;
            

}


}


}
