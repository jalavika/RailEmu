
















// Generated on 10/13/2017 02:17:23
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class GameFightMinimalStats
{

public const short Id = 31;
public virtual short TypeId
{
    get { return Id; }
}

public int lifePoints;
        public int maxLifePoints;
        public int baseMaxLifePoints;
        public int permanentDamagePercent;
        public int shieldPoints;
        public short actionPoints;
        public short movementPoints;
        public int summoner;
        public short neutralElementResistPercent;
        public short earthElementResistPercent;
        public short waterElementResistPercent;
        public short airElementResistPercent;
        public short fireElementResistPercent;
        public short dodgePALostProbability;
        public short dodgePMLostProbability;
        public short tackleBlock;
        public short tackleEvade;
        public sbyte invisibilityState;
        

public GameFightMinimalStats()
{
}

public GameFightMinimalStats(int lifePoints, int maxLifePoints, int baseMaxLifePoints, int permanentDamagePercent, int shieldPoints, short actionPoints, short movementPoints, int summoner, short neutralElementResistPercent, short earthElementResistPercent, short waterElementResistPercent, short airElementResistPercent, short fireElementResistPercent, short dodgePALostProbability, short dodgePMLostProbability, short tackleBlock, short tackleEvade, sbyte invisibilityState)
        {
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.baseMaxLifePoints = baseMaxLifePoints;
            this.permanentDamagePercent = permanentDamagePercent;
            this.shieldPoints = shieldPoints;
            this.actionPoints = actionPoints;
            this.movementPoints = movementPoints;
            this.summoner = summoner;
            this.neutralElementResistPercent = neutralElementResistPercent;
            this.earthElementResistPercent = earthElementResistPercent;
            this.waterElementResistPercent = waterElementResistPercent;
            this.airElementResistPercent = airElementResistPercent;
            this.fireElementResistPercent = fireElementResistPercent;
            this.dodgePALostProbability = dodgePALostProbability;
            this.dodgePMLostProbability = dodgePMLostProbability;
            this.tackleBlock = tackleBlock;
            this.tackleEvade = tackleEvade;
            this.invisibilityState = invisibilityState;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(lifePoints);
            writer.WriteInt(maxLifePoints);
            writer.WriteInt(baseMaxLifePoints);
            writer.WriteInt(permanentDamagePercent);
            writer.WriteInt(shieldPoints);
            writer.WriteShort(actionPoints);
            writer.WriteShort(movementPoints);
            writer.WriteInt(summoner);
            writer.WriteShort(neutralElementResistPercent);
            writer.WriteShort(earthElementResistPercent);
            writer.WriteShort(waterElementResistPercent);
            writer.WriteShort(airElementResistPercent);
            writer.WriteShort(fireElementResistPercent);
            writer.WriteShort(dodgePALostProbability);
            writer.WriteShort(dodgePMLostProbability);
            writer.WriteShort(tackleBlock);
            writer.WriteShort(tackleEvade);
            writer.WriteSByte(invisibilityState);
            

}

public virtual void Deserialize(IDataReader reader)
{

lifePoints = reader.ReadInt();
            if (lifePoints < 0)
                throw new Exception("Forbidden value on lifePoints = " + lifePoints + ", it doesn't respect the following condition : lifePoints < 0");
            maxLifePoints = reader.ReadInt();
            if (maxLifePoints < 0)
                throw new Exception("Forbidden value on maxLifePoints = " + maxLifePoints + ", it doesn't respect the following condition : maxLifePoints < 0");
            baseMaxLifePoints = reader.ReadInt();
            if (baseMaxLifePoints < 0)
                throw new Exception("Forbidden value on baseMaxLifePoints = " + baseMaxLifePoints + ", it doesn't respect the following condition : baseMaxLifePoints < 0");
            permanentDamagePercent = reader.ReadInt();
            if (permanentDamagePercent < 0)
                throw new Exception("Forbidden value on permanentDamagePercent = " + permanentDamagePercent + ", it doesn't respect the following condition : permanentDamagePercent < 0");
            shieldPoints = reader.ReadInt();
            if (shieldPoints < 0)
                throw new Exception("Forbidden value on shieldPoints = " + shieldPoints + ", it doesn't respect the following condition : shieldPoints < 0");
            actionPoints = reader.ReadShort();
            movementPoints = reader.ReadShort();
            summoner = reader.ReadInt();
            neutralElementResistPercent = reader.ReadShort();
            earthElementResistPercent = reader.ReadShort();
            waterElementResistPercent = reader.ReadShort();
            airElementResistPercent = reader.ReadShort();
            fireElementResistPercent = reader.ReadShort();
            dodgePALostProbability = reader.ReadShort();
            if (dodgePALostProbability < 0)
                throw new Exception("Forbidden value on dodgePALostProbability = " + dodgePALostProbability + ", it doesn't respect the following condition : dodgePALostProbability < 0");
            dodgePMLostProbability = reader.ReadShort();
            if (dodgePMLostProbability < 0)
                throw new Exception("Forbidden value on dodgePMLostProbability = " + dodgePMLostProbability + ", it doesn't respect the following condition : dodgePMLostProbability < 0");
            tackleBlock = reader.ReadShort();
            if (tackleBlock < 0)
                throw new Exception("Forbidden value on tackleBlock = " + tackleBlock + ", it doesn't respect the following condition : tackleBlock < 0");
            tackleEvade = reader.ReadShort();
            if (tackleEvade < 0)
                throw new Exception("Forbidden value on tackleEvade = " + tackleEvade + ", it doesn't respect the following condition : tackleEvade < 0");
            invisibilityState = reader.ReadSByte();
            

}



}


}
