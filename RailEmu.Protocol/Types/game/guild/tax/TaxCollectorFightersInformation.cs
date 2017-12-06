
















// Generated on 10/13/2017 02:17:26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class TaxCollectorFightersInformation
{

public const short Id = 169;
public virtual short TypeId
{
    get { return Id; }
}

public int collectorId;
        public IEnumerable<Types.CharacterMinimalPlusLookInformations> allyCharactersInformations;
        public IEnumerable<Types.CharacterMinimalPlusLookInformations> enemyCharactersInformations;
        

public TaxCollectorFightersInformation()
{
}

public TaxCollectorFightersInformation(int collectorId, IEnumerable<Types.CharacterMinimalPlusLookInformations> allyCharactersInformations, IEnumerable<Types.CharacterMinimalPlusLookInformations> enemyCharactersInformations)
        {
            this.collectorId = collectorId;
            this.allyCharactersInformations = allyCharactersInformations;
            this.enemyCharactersInformations = enemyCharactersInformations;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(collectorId);
            var allyCharactersInformations_before = writer.Position;
            var allyCharactersInformations_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in allyCharactersInformations)
            {
                 entry.Serialize(writer);
                 allyCharactersInformations_count++;
            }
            var allyCharactersInformations_after = writer.Position;
            writer.Seek((int)allyCharactersInformations_before);
            writer.WriteUShort((ushort)allyCharactersInformations_count);
            writer.Seek((int)allyCharactersInformations_after);

            var enemyCharactersInformations_before = writer.Position;
            var enemyCharactersInformations_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in enemyCharactersInformations)
            {
                 entry.Serialize(writer);
                 enemyCharactersInformations_count++;
            }
            var enemyCharactersInformations_after = writer.Position;
            writer.Seek((int)enemyCharactersInformations_before);
            writer.WriteUShort((ushort)enemyCharactersInformations_count);
            writer.Seek((int)enemyCharactersInformations_after);

            

}

public virtual void Deserialize(IDataReader reader)
{

collectorId = reader.ReadInt();
            var limit = reader.ReadUShort();
            var allyCharactersInformations_ = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 allyCharactersInformations_[i] = new Types.CharacterMinimalPlusLookInformations();
                 allyCharactersInformations_[i].Deserialize(reader);
            }
            allyCharactersInformations = allyCharactersInformations_;
            limit = reader.ReadUShort();
            var enemyCharactersInformations_ = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 enemyCharactersInformations_[i] = new Types.CharacterMinimalPlusLookInformations();
                 enemyCharactersInformations_[i].Deserialize(reader);
            }
            enemyCharactersInformations = enemyCharactersInformations_;
            

}



}


}
