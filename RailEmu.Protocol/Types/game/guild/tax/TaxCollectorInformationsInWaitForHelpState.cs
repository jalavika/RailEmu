
















// Generated on 10/13/2017 02:17:26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class TaxCollectorInformationsInWaitForHelpState : TaxCollectorInformations
{

public const short Id = 166;
public override short TypeId
{
    get { return Id; }
}

public Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo;
        

public TaxCollectorInformationsInWaitForHelpState()
{
}

public TaxCollectorInformationsInWaitForHelpState(int uniqueId, short firtNameId, short lastNameId, Types.AdditionalTaxCollectorInformations additonalInformation, short worldX, short worldY, short subAreaId, sbyte state, Types.EntityLook look, int kamas, double experience, int pods, int itemsValue, Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo)
         : base(uniqueId, firtNameId, lastNameId, additonalInformation, worldX, worldY, subAreaId, state, look, kamas, experience, pods, itemsValue)
        {
            this.waitingForHelpInfo = waitingForHelpInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            waitingForHelpInfo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            waitingForHelpInfo = new Types.ProtectedEntityWaitingForHelpInfo();
            waitingForHelpInfo.Deserialize(reader);
            

}



}


}
