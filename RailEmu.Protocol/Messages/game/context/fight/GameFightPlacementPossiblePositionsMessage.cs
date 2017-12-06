
















// Generated on 10/13/2017 02:18:46
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameFightPlacementPossiblePositionsMessage : Message
{

public const uint Id = 703;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<short> positionsForChallengers;
        public IEnumerable<short> positionsForDefenders;
        public sbyte teamNumber;
        

public GameFightPlacementPossiblePositionsMessage()
{
}

public GameFightPlacementPossiblePositionsMessage(IEnumerable<short> positionsForChallengers, IEnumerable<short> positionsForDefenders, sbyte teamNumber)
        {
            this.positionsForChallengers = positionsForChallengers;
            this.positionsForDefenders = positionsForDefenders;
            this.teamNumber = teamNumber;
        }
        

public override void Serialize(IDataWriter writer)
{

var positionsForChallengers_before = writer.Position;
            var positionsForChallengers_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in positionsForChallengers)
            {
                 writer.WriteShort(entry);
                 positionsForChallengers_count++;
            }
            var positionsForChallengers_after = writer.Position;
            writer.Seek((int)positionsForChallengers_before);
            writer.WriteUShort((ushort)positionsForChallengers_count);
            writer.Seek((int)positionsForChallengers_after);

            var positionsForDefenders_before = writer.Position;
            var positionsForDefenders_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in positionsForDefenders)
            {
                 writer.WriteShort(entry);
                 positionsForDefenders_count++;
            }
            var positionsForDefenders_after = writer.Position;
            writer.Seek((int)positionsForDefenders_before);
            writer.WriteUShort((ushort)positionsForDefenders_count);
            writer.Seek((int)positionsForDefenders_after);

            writer.WriteSByte(teamNumber);
            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var positionsForChallengers_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 positionsForChallengers_[i] = reader.ReadShort();
            }
            positionsForChallengers = positionsForChallengers_;
            limit = reader.ReadUShort();
            var positionsForDefenders_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 positionsForDefenders_[i] = reader.ReadShort();
            }
            positionsForDefenders = positionsForDefenders_;
            teamNumber = reader.ReadSByte();
            if (teamNumber < 0)
                throw new Exception("Forbidden value on teamNumber = " + teamNumber + ", it doesn't respect the following condition : teamNumber < 0");
            

}


}


}
