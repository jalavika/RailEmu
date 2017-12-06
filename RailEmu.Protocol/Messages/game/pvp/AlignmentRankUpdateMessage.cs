
















// Generated on 10/13/2017 02:19:06
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class AlignmentRankUpdateMessage : Message
{

public const uint Id = 6058;
public override uint MessageId
{
    get { return Id; }
}

public sbyte alignmentRank;
        public bool verbose;
        

public AlignmentRankUpdateMessage()
{
}

public AlignmentRankUpdateMessage(sbyte alignmentRank, bool verbose)
        {
            this.alignmentRank = alignmentRank;
            this.verbose = verbose;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(alignmentRank);
            writer.WriteBoolean(verbose);
            

}

public override void Deserialize(IDataReader reader)
{

alignmentRank = reader.ReadSByte();
            if (alignmentRank < 0)
                throw new Exception("Forbidden value on alignmentRank = " + alignmentRank + ", it doesn't respect the following condition : alignmentRank < 0");
            verbose = reader.ReadBoolean();
            

}


}


}
