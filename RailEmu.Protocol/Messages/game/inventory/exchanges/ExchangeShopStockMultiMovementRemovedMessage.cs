
















// Generated on 10/13/2017 02:19:01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeShopStockMultiMovementRemovedMessage : Message
{

public const uint Id = 6037;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<int> objectIdList;
        

public ExchangeShopStockMultiMovementRemovedMessage()
{
}

public ExchangeShopStockMultiMovementRemovedMessage(IEnumerable<int> objectIdList)
        {
            this.objectIdList = objectIdList;
        }
        

public override void Serialize(IDataWriter writer)
{

var objectIdList_before = writer.Position;
            var objectIdList_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in objectIdList)
            {
                 writer.WriteInt(entry);
                 objectIdList_count++;
            }
            var objectIdList_after = writer.Position;
            writer.Seek((int)objectIdList_before);
            writer.WriteUShort((ushort)objectIdList_count);
            writer.Seek((int)objectIdList_after);

            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var objectIdList_ = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectIdList_[i] = reader.ReadInt();
            }
            objectIdList = objectIdList_;
            

}


}


}
