
















// Generated on 10/13/2017 02:17:23
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class AtlasPointsInformations
{

public const short Id = 175;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte type;
        public IEnumerable<Types.MapCoordinatesExtended> coords;
        

public AtlasPointsInformations()
{
}

public AtlasPointsInformations(sbyte type, IEnumerable<Types.MapCoordinatesExtended> coords)
        {
            this.type = type;
            this.coords = coords;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSByte(type);
            var coords_before = writer.Position;
            var coords_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in coords)
            {
                 entry.Serialize(writer);
                 coords_count++;
            }
            var coords_after = writer.Position;
            writer.Seek((int)coords_before);
            writer.WriteUShort((ushort)coords_count);
            writer.Seek((int)coords_after);

            

}

public virtual void Deserialize(IDataReader reader)
{

type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            var limit = reader.ReadUShort();
            var coords_ = new Types.MapCoordinatesExtended[limit];
            for (int i = 0; i < limit; i++)
            {
                 coords_[i] = new Types.MapCoordinatesExtended();
                 coords_[i].Deserialize(reader);
            }
            coords = coords_;
            

}



}


}
