
















// Generated on 10/13/2017 02:19:02
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeStartOkMountMessage : ExchangeStartOkMountWithOutPaddockMessage
{

public const uint Id = 5979;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<Types.MountClientData> paddockedMountsDescription;
        

public ExchangeStartOkMountMessage()
{
}

public ExchangeStartOkMountMessage(IEnumerable<Types.MountClientData> stabledMountsDescription, IEnumerable<Types.MountClientData> paddockedMountsDescription)
         : base(stabledMountsDescription)
        {
            this.paddockedMountsDescription = paddockedMountsDescription;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            var paddockedMountsDescription_before = writer.Position;
            var paddockedMountsDescription_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in paddockedMountsDescription)
            {
                 entry.Serialize(writer);
                 paddockedMountsDescription_count++;
            }
            var paddockedMountsDescription_after = writer.Position;
            writer.Seek((int)paddockedMountsDescription_before);
            writer.WriteUShort((ushort)paddockedMountsDescription_count);
            writer.Seek((int)paddockedMountsDescription_after);

            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            var paddockedMountsDescription_ = new Types.MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddockedMountsDescription_[i] = new Types.MountClientData();
                 paddockedMountsDescription_[i].Deserialize(reader);
            }
            paddockedMountsDescription = paddockedMountsDescription_;
            

}


}


}
