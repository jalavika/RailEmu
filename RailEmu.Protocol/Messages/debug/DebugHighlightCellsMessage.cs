
















// Generated on 10/13/2017 02:18:38
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class DebugHighlightCellsMessage : Message
{

public const uint Id = 2001;
public override uint MessageId
{
    get { return Id; }
}

public int color;
        public IEnumerable<short> cells;
        

public DebugHighlightCellsMessage()
{
}

public DebugHighlightCellsMessage(int color, IEnumerable<short> cells)
        {
            this.color = color;
            this.cells = cells;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(color);
            var cells_before = writer.Position;
            var cells_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in cells)
            {
                 writer.WriteShort(entry);
                 cells_count++;
            }
            var cells_after = writer.Position;
            writer.Seek((int)cells_before);
            writer.WriteUShort((ushort)cells_count);
            writer.Seek((int)cells_after);

            

}

public override void Deserialize(IDataReader reader)
{

color = reader.ReadInt();
            var limit = reader.ReadUShort();
            var cells_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells_[i] = reader.ReadShort();
            }
            cells = cells_;
            

}


}


}
