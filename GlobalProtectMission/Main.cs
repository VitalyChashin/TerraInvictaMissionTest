using UnityEngine;
using UnityModManagerNet;

namespace GlobalProtectMission
{
    public class Main
    {
        
        public static bool enabled;

        public static UnityModManager.ModEntry mod;

        static bool Load(UnityModManager.ModEntry modEntry)
        {
            TIMissionEffect_GlobalProtect tim = new TIMissionEffect_GlobalProtect(); //load it

            return true;
        }
    }
}