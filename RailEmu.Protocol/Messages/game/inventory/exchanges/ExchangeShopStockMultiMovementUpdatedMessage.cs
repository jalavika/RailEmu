
















// Generated on 10/13/2017 02:19:01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeShopStockMultiMovementUpdatedMessage : Message
{

public const uint Id = 6038;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<Types.ObjectItemToSell> objectInfoList;
        

public ExchangeShopStockMultiMovementUpdatedMessage()
{
}

public ExchangeShopStockMultiMovementUpdatedMessage(IEnumerable<Types.ObjectItemToSell> objectInfoList)
        {
            this.objectInfoList = objectInfoList;
        }
        

public override void Serialize(IDataWriter writer)
{

var objectInfoList_before = writer.Position;
            var objectInfoList_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in objectInfoList)
            {
                 entry.Serialize(writer);
                 objectInfoList_count++;
            }
            var objectInfoList_after = writer.Position;
            writer.Seek((int)objectInfoList_before);
            writer.WriteUShort((ushort)objectInfoList_count);
            writer.Seek((int)objectInfoList_after);

            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var objectInfoList_ = new Types.ObjectItemToSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectInfoList_[i] = new Types.ObjectItemToSell();
                 objectInfoList_[i].Deserialize(reader);
            }
            objectInfoList = objectInfoList_;
            

}


}


}
