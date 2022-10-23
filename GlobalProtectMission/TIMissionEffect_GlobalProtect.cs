
    using PavonisInteractive.TerraInvicta;
    using UnityEngine;

    public class TIMissionEffect_GlobalProtect:TIMissionEffect
    {
        public override string ApplyEffect(TIMissionState mission, TIGameState target, TIMissionOutcome outcome = TIMissionOutcome.Success)
        {
            

           
            string result = "";

            string pointDate = "";

            int pointCount = 0;

            foreach (var factionControlPoint in mission.councilor.faction.controlPoints)
            {
                pointDate= factionControlPoint.ResolveDefendControlPointEffect(6);
                pointCount++;
            }

            string habDate = "";
            int habCount = 0;

            foreach (var factionHab in mission.councilor.faction.habs)
            {
                habDate= factionHab.ResolveDefendHabEffect(mission.councilor.faction, 12);
                habCount++;
            }

            result = Loc.T("TIMissionTemplate.GlobalProtect.pointProtect") + " " + pointCount + " " +
                     Loc.T("TIMissionTemplate.GlobalProtect.till") + " " + pointDate;

            if (habCount > 0)
            {
                result = result + "\n" + Loc.T("TIMissionTemplate.GlobalProtect.habProtect") + " " + pointCount + " " +
                         Loc.T("TIMissionTemplate.GlobalProtect.till") + " " + habDate;
            }

            return result;
        }
    }
