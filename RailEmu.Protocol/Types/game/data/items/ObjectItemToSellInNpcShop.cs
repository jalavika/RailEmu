
















// Generated on 10/13/2017 02:17:25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
{

public const short Id = 352;
public override short TypeId
{
    get { return Id; }
}

public int objectPrice;
        public string buyCriterion;
        

public ObjectItemToSellInNpcShop()
{
}

public ObjectItemToSellInNpcShop(short objectGID, short powerRate, bool overMax, IEnumerable<Types.ObjectEffect> effects, int objectPrice, string buyCriterion)
         : base(objectGID, powerRate, overMax, effects)
        {
            this.objectPrice = objectPrice;
            this.buyCriterion = buyCriterion;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(objectPrice);
            writer.WriteUTF(buyCriterion);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            objectPrice = reader.ReadInt();
            if (objectPrice < 0)
                throw new Exception("Forbidden value on objectPrice = " + objectPrice + ", it doesn't respect the following condition : objectPrice < 0");
            buyCriterion = reader.ReadUTF();
            

}



}


}
