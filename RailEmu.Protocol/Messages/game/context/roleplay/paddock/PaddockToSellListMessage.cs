
















// Generated on 10/13/2017 02:18:52
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class PaddockToSellListMessage : Message
{

public const uint Id = 6138;
public override uint MessageId
{
    get { return Id; }
}

public short pageIndex;
        public short totalPage;
        public IEnumerable<Types.PaddockInformationsForSell> paddockList;
        

public PaddockToSellListMessage()
{
}

public PaddockToSellListMessage(short pageIndex, short totalPage, IEnumerable<Types.PaddockInformationsForSell> paddockList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.paddockList = paddockList;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(pageIndex);
            writer.WriteShort(totalPage);
            var paddockList_before = writer.Position;
            var paddockList_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in paddockList)
            {
                 entry.Serialize(writer);
                 paddockList_count++;
            }
            var paddockList_after = writer.Position;
            writer.Seek((int)paddockList_before);
            writer.WriteUShort((ushort)paddockList_count);
            writer.Seek((int)paddockList_after);

            

}

public override void Deserialize(IDataReader reader)
{

pageIndex = reader.ReadShort();
            if (pageIndex < 0)
                throw new Exception("Forbidden value on pageIndex = " + pageIndex + ", it doesn't respect the following condition : pageIndex < 0");
            totalPage = reader.ReadShort();
            if (totalPage < 0)
                throw new Exception("Forbidden value on totalPage = " + totalPage + ", it doesn't respect the following condition : totalPage < 0");
            var limit = reader.ReadUShort();
            var paddockList_ = new Types.PaddockInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddockList_[i] = new Types.PaddockInformationsForSell();
                 paddockList_[i].Deserialize(reader);
            }
            paddockList = paddockList_;
            

}


}


}
