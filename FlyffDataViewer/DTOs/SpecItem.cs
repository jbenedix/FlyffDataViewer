﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyffDataViewer.DTOs
{
    public class SpecItem
    {
        //Own Settings
        public string ID { get; set; }
        public string ingameName { get; set; }

        //From Propitem
        public string dwID { get; set; }
        public string szName { get; set; }
        public int dwPackMax { get; set; }
        public string dwItemKind2 { get; set; }
        public string dwItemKind1 { get; set; }
        public string dwItemKind3 { get; set; }
        public string szComment { get; set; }
        public string dwCost { get; set; }


        public string dwCircleTime { get; set; }
        public string dwItemLV { get; set; }
        public string dwItemRare { get; set; }
        public string dwItemJob { get; set; }

        public string dwHanded { get; set; }
        public string dwAbilityMin { get; set; }
        public string dwAbilityMax { get; set; }
        public string dwWeaponType { get; set; }
        public string dwAttackRange { get; set; }
        public string dwAttackSpeed { get; set; }
        public string dwDestParam1 { get; set; }
        public string dwDestParam2 { get; set; }
        public string dwDestParam3 { get; set; }
        public string dwDestParam4 { get; set; }
        public string dwDestParam5 { get; set; }
        public string dwDestParam6 { get; set; }

        public string nAdjParamVal1 { get; set; }
        public string nAdjParamVal2 { get; set; }
        public string nAdjParamVal3 { get; set; }
        public string nAdjParamVal4 { get; set; }
        public string nAdjParamVal5 { get; set; }
        public string nAdjParamVal6 { get; set; }

        public string dwactiveskill { get; set; }
    }
}
