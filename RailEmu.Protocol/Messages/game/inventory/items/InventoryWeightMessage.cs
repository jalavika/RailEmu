
















// Generated on 10/13/2017 02:19:03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class InventoryWeightMessage : Message
{

public const uint Id = 3009;
public override uint MessageId
{
    get { return Id; }
}

public int weight;
        public int weightMax;
        

public InventoryWeightMessage()
{
}

public InventoryWeightMessage(int weight, int weightMax)
        {
            this.weight = weight;
            this.weightMax = weightMax;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(weight);
            writer.WriteInt(weightMax);
            

}

public override void Deserialize(IDataReader reader)
{

weight = reader.ReadInt();
            if (weight < 0)
                throw new Exception("Forbidden value on weight = " + weight + ", it doesn't respect the following condition : weight < 0");
            weightMax = reader.ReadInt();
            if (weightMax < 0)
                throw new Exception("Forbidden value on weightMax = " + weightMax + ", it doesn't respect the following condition : weightMax < 0");
            

}


}


}
