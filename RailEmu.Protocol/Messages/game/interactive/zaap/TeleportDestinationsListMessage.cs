
















// Generated on 10/13/2017 02:18:58
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class TeleportDestinationsListMessage : Message
{

public const uint Id = 5960;
public override uint MessageId
{
    get { return Id; }
}

public sbyte teleporterType;
        public IEnumerable<int> mapIds;
        public IEnumerable<short> subareaIds;
        public IEnumerable<short> costs;
        

public TeleportDestinationsListMessage()
{
}

public TeleportDestinationsListMessage(sbyte teleporterType, IEnumerable<int> mapIds, IEnumerable<short> subareaIds, IEnumerable<short> costs)
        {
            this.teleporterType = teleporterType;
            this.mapIds = mapIds;
            this.subareaIds = subareaIds;
            this.costs = costs;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(teleporterType);
            var mapIds_before = writer.Position;
            var mapIds_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in mapIds)
            {
                 writer.WriteInt(entry);
                 mapIds_count++;
            }
            var mapIds_after = writer.Position;
            writer.Seek((int)mapIds_before);
            writer.WriteUShort((ushort)mapIds_count);
            writer.Seek((int)mapIds_after);

            var subareaIds_before = writer.Position;
            var subareaIds_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in subareaIds)
            {
                 writer.WriteShort(entry);
                 subareaIds_count++;
            }
            var subareaIds_after = writer.Position;
            writer.Seek((int)subareaIds_before);
            writer.WriteUShort((ushort)subareaIds_count);
            writer.Seek((int)subareaIds_after);

            var costs_before = writer.Position;
            var costs_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in costs)
            {
                 writer.WriteShort(entry);
                 costs_count++;
            }
            var costs_after = writer.Position;
            writer.Seek((int)costs_before);
            writer.WriteUShort((ushort)costs_count);
            writer.Seek((int)costs_after);

            

}

public override void Deserialize(IDataReader reader)
{

teleporterType = reader.ReadSByte();
            if (teleporterType < 0)
                throw new Exception("Forbidden value on teleporterType = " + teleporterType + ", it doesn't respect the following condition : teleporterType < 0");
            var limit = reader.ReadUShort();
            var mapIds_ = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 mapIds_[i] = reader.ReadInt();
            }
            mapIds = mapIds_;
            limit = reader.ReadUShort();
            var subareaIds_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 subareaIds_[i] = reader.ReadShort();
            }
            subareaIds = subareaIds_;
            limit = reader.ReadUShort();
            var costs_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 costs_[i] = reader.ReadShort();
            }
            costs = costs_;
            

}


}


}
