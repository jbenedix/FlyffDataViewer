using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyffDataViewer.DTOs
{
    public class PropMoverDTO
    {
        public string ID { get; set; }
        public string dwID { get; set; }
        public string szName { get; set; }

        public string ingameName { get; set; }
        public string description { get; set; }
        public string dwAI { get; set; }
        public string dwStr { get; set; }
        public string dwSta { get; set; }
        public string dwDex { get; set; }
        public string dwInt { get; set; }
        public string dwClass { get; set; }
        public string dwLevel { get; set; }
        public string dwAtkMin { get; set; }
        public string dwAtkMax { get; set; }
        public string dwAddHp { get; set; }
        public string fSpeed { get; set; }
        public string dwResisMagic { get; set; }
        public string fResistElectricity { get; set; }
        public string fResistFire { get; set; }
        public string fResistWind { get; set; }
        public string fResistWater { get; set; }
        public string fResistEarth { get; set; }
        public string dwExpValue { get; set; }
        public string szComment { get; set; }
        public string dwAreaColor { get; set; }
    }
}
