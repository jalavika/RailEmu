
















// Generated on 10/13/2017 02:18:48
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class MapObstacleUpdateMessage : Message
{

public const uint Id = 6051;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<Types.MapObstacle> obstacles;
        

public MapObstacleUpdateMessage()
{
}

public MapObstacleUpdateMessage(IEnumerable<Types.MapObstacle> obstacles)
        {
            this.obstacles = obstacles;
        }
        

public override void Serialize(IDataWriter writer)
{

var obstacles_before = writer.Position;
            var obstacles_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in obstacles)
            {
                 entry.Serialize(writer);
                 obstacles_count++;
            }
            var obstacles_after = writer.Position;
            writer.Seek((int)obstacles_before);
            writer.WriteUShort((ushort)obstacles_count);
            writer.Seek((int)obstacles_after);

            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var obstacles_ = new Types.MapObstacle[limit];
            for (int i = 0; i < limit; i++)
            {
                 obstacles_[i] = new Types.MapObstacle();
                 obstacles_[i].Deserialize(reader);
            }
            obstacles = obstacles_;
            

}


}


}
