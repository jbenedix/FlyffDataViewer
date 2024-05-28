using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using FlyffDataViewer.DTOs;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace FlyffDataViewer.Classes
{
    public static class ContentManager
    {
        public static List<SpecItem> Items = new List<SpecItem>();
        public static List<PropTxtTxt> ItemsDescription = new List<PropTxtTxt>();
        public static List<DefineItem> defineItems = new List<DefineItem>();
        public static List<SpecItem> SpecItems = new List<SpecItem>();
        public static List<PropMoverDTO> Movers = new List<PropMoverDTO>();
        public static List<PropTxtTxt> MoversDescription = new List<PropTxtTxt>();
        public static List<DefineObj> DefineObjs = new List<DefineObj>();

        public static List<string> specitemtxt = new List<string>();
        public static List<string> propitemtxttxt = new List<string>();
        public static List<string> propmovertxt = new List<string>();
        public static List<string> propmovertxttxt = new List<string>();
        public static List<string> ShopList = new List<string>();


        public static void LoadItems()
        {
            LoadSpecItemTxt();
            Console.WriteLine(specitemtxt);
            LoadPropItemTxtTxt();
            Console.WriteLine(propitemtxttxt);
            LoadDefineItems();
            Console.WriteLine(defineItems);
            updateItemIngameName();
            Console.WriteLine(Items);

        }

        public static void LoadMovers()
        {
            LoadPropMoverTXT();
            LoadMoversTxtTxt();
            loadDefineObjs();
            UpdateMovers();

        }

        public static void LoadMoversTxtTxt()
        {
            propmovertxttxt = File.ReadAllLines(SettingsManager.resourcePath + "\\propMover.txt.txt").ToList();
            foreach (string line in propmovertxttxt)
            {
                var splittedLine = line.Split('\t');
                if (splittedLine.Last().Length > 0)
                {
                    var proptxttxt = new PropTxtTxt
                    {
                        ID = splittedLine.First(),
                        Name = splittedLine.Last()
                    };
                    MoversDescription.Add(proptxttxt);
                }
            }
        }

        public static void LoadPropMoverTXT()
        {
            propmovertxt = File.ReadAllLines(SettingsManager.resourcePath + "\\propMover.txt").ToList();
            propmovertxt = propmovertxt.Distinct().ToList();

            int dwIDIndex = 0;
            int szNameIndex = 1;
            int dwAIIndex = 2;
            int dwStrIndex = 3;
            int dwStaIndex = 4;
            int dwDexIndex = 5;
            int dwIntIndex = 6;
            int dwClassIndex = 7;
            int dwLevelIndex = 8;
            int dwAtkMinIndex = 9;
            int dwAtkMaxIndex = 10;
            int dwAddHpIndex = 11;
            int fSpeedIndex = 12;
            int dwResisMagicIndex = 13;
            int fResistElectricityIndex = 14;
            int fResistFireIndex = 15;
            int fResistWindIndex = 16;
            int fResistWaterIndex = 17;
            int fResistEarthIndex = 18;
            int dwExpValueIndex = 19;
            int szCommentIndex = 20;
            int dwAreaColorIndex = 21;

            int headlineNumber = 1;

            //find header_line
            for (int i = 0; i < propmovertxt.Count; i++)
            {
                if (propmovertxt[i].Contains("dwID") && propmovertxt[i].Contains("szName"))
                {
                    headlineNumber = i;
                }
            }

            //Find Indexes:
            var temp = propmovertxt[headlineNumber].Split('\t');
            for (int i = 0; i < temp.Length; i++)
            {
                switch (temp[i])
                {
                    case "dwID":
                        {
                            dwIDIndex = i;
                        }
                        break;

                    case "szName":
                        {
                            szNameIndex = i;
                        }
                        break;

                    case "dwAI":
                        {
                            dwAIIndex = i;
                        }
                        break;

                    case "dwStr":
                        {
                            dwStrIndex = i;
                        }
                        break;

                    case "dwSta":
                        {
                            dwStaIndex = i;
                        }
                        break;

                    case "dwDex":
                        {
                            dwDexIndex = i;
                        }
                        break;

                    case "dwInt":
                        {
                            dwIntIndex = i;
                        }
                        break;

                    case "dwClass":
                        {
                            dwClassIndex = i;
                        }
                        break;

                    case "dwLevel":
                        {
                            dwLevelIndex = i;
                        }
                        break;

                    case "dwAtkMin":
                        {
                            dwAtkMinIndex = i;
                        }
                        break;

                    case "dwAtkMax":
                        {
                            dwAtkMaxIndex = i;
                        }
                        break;

                    case "dwAddHp":
                        {
                            dwAddHpIndex = i;
                        }
                        break;

                    case "fSpeed":
                        {
                            fSpeedIndex = i;
                        }
                        break;

                    case "dwResisMagic":
                        {
                            dwResisMagicIndex = i;
                        }
                        break;

                    case "fResistElectricity":
                        {
                            fResistElectricityIndex = i;
                        }
                        break;

                    case "fResistFire":
                        {
                            fResistFireIndex = i;
                        }
                        break;

                    case "fResistWind":
                        {
                            fResistWindIndex = i;
                        }
                        break;

                    case "fResistWater":
                        {
                            fResistWaterIndex = i;
                        }
                        break;

                    case "fResistEarth":
                        {
                            fResistEarthIndex = i;
                        }
                        break;

                    case "dwExpValue":
                        {
                            dwExpValueIndex = i;
                        }
                        break;

                    case "szComment":
                        {
                            szCommentIndex = i;
                        }
                        break;

                    case "dwAreaColor":
                        {
                            dwAreaColorIndex = i;
                        }
                        break;
                }
            }

            for (int i = headlineNumber + 1; i < propmovertxt.Count; i++)
            {
                var test = propmovertxt[i].Split('\t').Length;
                if (propmovertxt[i].Split('\t').Length == 86)
                {
                    var splittedLine = propmovertxt[i].Split('\t');
                    var propmoveritem = new PropMoverDTO
                    {
                        dwID = splittedLine[dwIDIndex],
                        szName = splittedLine[szNameIndex],
                        dwAI = splittedLine[dwAIIndex],
                        dwStr = splittedLine[dwStrIndex],
                        dwSta = splittedLine[dwStaIndex],
                        dwDex = splittedLine[dwDexIndex],
                        dwInt = splittedLine[dwIntIndex],
                        dwClass = splittedLine[dwClassIndex],
                        dwLevel = splittedLine[dwLevelIndex],
                        dwAtkMin = splittedLine[dwAtkMinIndex],
                        dwAtkMax = splittedLine[dwAtkMaxIndex],
                        dwAddHp = splittedLine[dwAddHpIndex],
                        fSpeed = splittedLine[fSpeedIndex],
                        dwResisMagic = splittedLine[dwResisMagicIndex],
                        fResistElectricity = splittedLine[fResistElectricityIndex],
                        fResistFire = splittedLine[fResistFireIndex],
                        fResistWind = splittedLine[fResistWindIndex],
                        fResistWater = splittedLine[fResistWaterIndex],
                        fResistEarth = splittedLine[fResistEarthIndex],
                        dwExpValue = splittedLine[dwExpValueIndex],
                        szComment = splittedLine[szCommentIndex],
                        dwAreaColor = splittedLine[dwAreaColorIndex]


                    };
                    Movers.Add(propmoveritem);
                }
            }
        }

        public static void UpdateMovers()
        {
            foreach (var item in Movers)
            {
                var igname = "";
                var desc = "";
                var id = "";
                if (item.szName.Length > 0)
                {
                    foreach (var name in MoversDescription)
                    {
                        if(item.szName == name.ID)
                        {
                            igname = name.Name;
                        }
                    }
                    
                }
                if (item.szComment.Length > 0)
                {
                    foreach (var descript in MoversDescription)
                    {
                        if (item.szComment == descript.ID)
                        {
                            desc = descript.Name;
                        }
                    }

                }
                if(item.dwID.Length > 0)
                {
                    foreach(var dobj in DefineObjs)
                    {
                        if(item.dwID == dobj.name)
                        {
                            id = dobj.id;
                        }
                    }
                }
                item.ingameName = igname;
                item.description = desc;
                item.ID = id;

            }

            //Remove empty Name Entries
            Movers.RemoveAll(x => x.ingameName.Length == 0);
        }

        public static void loadDefineObjs()
        {
            var content = File.ReadAllLines(SettingsManager.resourcePath + "\\defineObj.h").ToList();
            foreach (var item in content)
            {
                string pattern = @"#define\s+(\w+)\s+[\t\s]+(\d+)";
                Match match = Regex.Match(item, pattern);

                // Wenn eine Übereinstimmung gefunden wurde, extrahieren Sie Name und ID
                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    string id = match.Groups[2].Value;
                    DefineObj di = new DefineObj
                    {
                        name = name,
                        id = id
                    };
                    DefineObjs.Add(di);
                }

            }
        }

        public static void LoadSpecItemTxt()
        {
            //Load propitem.txt
            specitemtxt = File.ReadAllLines(SettingsManager.resourcePath + "\\Spec_Item.txt").ToList();
            specitemtxt = specitemtxt.Distinct().ToList();
            int dwIDIndex = 1;
            int szNameIndex = 2;
            int dwPackMaxIndex = 3;
            int dwItemKind2Index = 4;
            int dwItemKind1Index = 5;
            int dwCostIndex = 6;
            int szCommentIndex = 7;
            int dwCircleTimeIndex = 8;
            int dwHandedIndex = 9;
            int dwItemLVIndex = 10;
            int dwItemRareIndex = 11;
            int dwItemJobIndex = 12;
            int dwItemKind3Index = 13;
            int dwAbilityMinIndex = 14;
            int dwAbilityMaxIndex = 15;
            int dwWeaponTypeIndex = 16;
            int dwAttackRangeIndex = 17;
            int dwAttackSpeedIndex = 18;
            int dwDestParam1Index = 0;
            int dwDestParam2Index = 0;
            int dwDestParam3Index = 0;
            int dwDestParam4Index = 0;
            int dwDestParam5Index = 0;
            int dwDestParam6Index = 0;
            int nAdjParamVal1Index = 0;
            int nAdjParamVal2Index = 0;
            int nAdjParamVal3Index = 0;
            int nAdjParamVal4Index = 0;
            int nAdjParamVal5Index = 0;
            int nAdjParamVal6Index = 0;

            int dwactiveskillIndex = 0;

            int headlineNumber = 1;

            //find header_line
            for (int i = 0; i < specitemtxt.Count; i++)
            {
                if (specitemtxt[i].Contains("dwID") && specitemtxt[i].Contains("szName"))
                {
                    headlineNumber = i;
                }
            }

            //Find Indexes:
            var temp = specitemtxt[headlineNumber].Split('\t');
            for (int i = 0; i < temp.Length; i++)
            {
                switch (temp[i])
                {
                    case "//dwID":
                        {
                            dwIDIndex = i;
                        }
                        break;
                    case "szName":
                        {
                            szNameIndex = i;
                        }
                        break;
                    case "dwPackMax":
                        {
                            dwPackMaxIndex = i;
                        }
                        break;
                    case "dwItemKind2":
                        {
                            dwItemKind2Index = i;
                        }break;
                    case "dwItemKind1":
                        {
                            dwItemKind1Index = i;
                        }
                        break;
                    case "dwCost":
                        {
                            dwCostIndex = i;
                        }
                        break;

                    case "szComment":
                        {
                            szCommentIndex = i;
                        }
                        break;

                    case "dwCircleTime":
                        {
                            dwCircleTimeIndex = i;
                        }
                        break;

                    case "dwHanded":
                        {
                            dwHandedIndex = i;
                        }
                        break;

                    case "dwItemLV":
                        {
                            dwItemLVIndex = i;
                        }
                        break;

                    case "dwItemRare":
                        {
                            dwItemRareIndex = i;
                        }
                        break;

                    case "dwItemJob":
                        {
                            dwItemJobIndex = i;
                        }
                        break;

                    case "dwItemKind3":
                        {
                            dwItemKind3Index = i;
                        }
                        break;

                    case "dwAbilityMin":
                        {
                            dwAbilityMinIndex = i;
                        }
                        break;

                    case "dwAbilityMax":
                        {
                            dwAbilityMaxIndex = i;
                        }
                        break;

                    case "dwWeaponType":
                        {
                            dwWeaponTypeIndex = i;
                        }
                        break;

                    case "dwAttackRange":
                        {
                            dwAttackRangeIndex = i;
                        }
                        break;

                    case "dwAttackSpeed":
                        {
                            dwAttackSpeedIndex = i;
                        }
                        break;
                    case "dwDestParam1":
                        dwDestParam1Index = i;
                        break;
                    case "dwDestParam2":
                        dwDestParam2Index = i;
                        break;
                    case "dwDestParam3":
                        dwDestParam3Index = i;
                        break;
                    case "dwDestParam4":
                        dwDestParam4Index = i;
                        break;
                    case "dwDestParam5":
                        dwDestParam5Index = i;
                        break;
                    case "dwDestParam6":
                        dwDestParam6Index = i;
                        break;
                    case "nAdjParamVal1":
                        nAdjParamVal1Index = i;
                        break;
                    case "nAdjParamVal2":
                        nAdjParamVal2Index = i;
                        break;
                    case "nAdjParamVal3":
                        nAdjParamVal3Index = i;
                        break;
                    case "nAdjParamVal4":
                        nAdjParamVal4Index = i;
                        break;
                    case "nAdjParamVal5":
                        nAdjParamVal5Index = i;
                        break;
                    case "nAdjParamVal6":
                        nAdjParamVal6Index = i;
                        break;
                    case "dwactiveskill":
                        dwactiveskillIndex = i;
                        break;
                }

            }
            for (int i = headlineNumber + 1; i < specitemtxt.Count; i++)
            {
                var test = specitemtxt[i].Split('\t').Length;
                if (specitemtxt[i].Split('\t').Length == 171)
                {
                    var splittedLine = specitemtxt[i].Split('\t');
                    var dwPackMax = 1;
                    try
                    {
                        dwPackMax = int.Parse(splittedLine[dwPackMaxIndex]);
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine(ex.Message + " --Wert:" +splittedLine[dwItemKind2Index]);
                    }
                    //int.Parse(splittedLine[dwPackMaxIndex]);
                    var propitemtxtObject = new SpecItem
                    {
                        dwID = splittedLine[dwIDIndex],
                        szName = splittedLine[szNameIndex],
                        dwItemKind2 = splittedLine[dwItemKind2Index],
                        dwItemKind1 = splittedLine[dwItemKind1Index],
                        dwCost = splittedLine[dwCostIndex],
                        szComment = splittedLine[szCommentIndex],
                        dwCircleTime = splittedLine[dwCircleTimeIndex],
                        dwHanded = splittedLine[dwHandedIndex],
                        dwItemLV = splittedLine[dwItemLVIndex],
                        dwItemRare = splittedLine[dwItemRareIndex],
                        dwItemJob = splittedLine[dwItemJobIndex],
                        dwItemKind3 = splittedLine[dwItemKind3Index],
                        dwAbilityMin = splittedLine[dwAbilityMinIndex],
                        dwAbilityMax = splittedLine[dwAbilityMaxIndex],
                        dwWeaponType = splittedLine[dwWeaponTypeIndex],
                        dwAttackRange = splittedLine[dwAttackRangeIndex],
                        dwAttackSpeed = splittedLine[dwAttackSpeedIndex],
                        dwDestParam1 = splittedLine[dwDestParam1Index],
                        dwDestParam2 = splittedLine[dwDestParam2Index],
                        dwDestParam3 = splittedLine[dwDestParam3Index],
                        dwDestParam4 = splittedLine[dwDestParam4Index],
                        dwDestParam5 = splittedLine[dwDestParam5Index],
                        dwDestParam6 = splittedLine[dwDestParam6Index],
                        nAdjParamVal1 = splittedLine[nAdjParamVal1Index],
                        nAdjParamVal2 = splittedLine[nAdjParamVal2Index],
                        nAdjParamVal3 = splittedLine[nAdjParamVal3Index],
                        nAdjParamVal4 = splittedLine[nAdjParamVal4Index],
                        nAdjParamVal5 = splittedLine[nAdjParamVal5Index],
                        nAdjParamVal6 = splittedLine[nAdjParamVal6Index],
                        dwactiveskill = splittedLine[dwactiveskillIndex],
                    };
                    Items.Add(propitemtxtObject);
                }

            }
        }
        public static void LoadPropItemTxtTxt()
        {
            propitemtxttxt = File.ReadAllLines(SettingsManager.resourcePath + "\\propItem.txt.txt").ToList();
            foreach (string line in propitemtxttxt)
            {
                var splittedLine = line.Split('\t');
                if (splittedLine.Last().Length > 0)
                {
                    var propitemtxttxtObject = new PropTxtTxt
                    {
                        ID = splittedLine.First(),
                        Name = splittedLine.Last()
                    };
                    ItemsDescription.Add(propitemtxttxtObject);
                }
            }
        }

        public static void LoadDefineItems()
        {
            var content = File.ReadAllLines(SettingsManager.resourcePath + "\\defineItem.h").ToList();
            foreach (var item in content)
            {
                if (item.StartsWith("#define"))
                {
                    var cuttedLine = item.Substring(8, item.Length - 8);
                    DefineItem di = new DefineItem
                    {
                        name = cuttedLine.Split(' ').First(),
                        id = cuttedLine.Split(' ').Last()
                    };
                    defineItems.Add(di);
                }
            }
        }

        public static void updateItemIngameName()
        {
            foreach (var item in Items)
            {
                string displayedname = "";
                string description = "";
                if (item.szName.Length > 0)
                {
                    var propitemtxtxttemp = ItemsDescription.SingleOrDefault(x => x.ID == item.szName);
                    var propitemtxtxtdesc = ItemsDescription.SingleOrDefault(x => x.ID == item.szComment);
                    if (propitemtxtxttemp is not null)
                    {
                        displayedname = propitemtxtxttemp.Name;
                    }
                    if (propitemtxtxtdesc is not null)
                    {
                        description = propitemtxtxtdesc.Name;
                    }
                    var defineItem = defineItems.SingleOrDefault(x => x.name == item.dwID);
                    if(defineItem is not null)
                    {
                        item.ID = defineItem.id;
                    }

                   
                }

                


                item.ingameName = displayedname;
                item.szComment = description;

            }
        }

        public static void OpenCSVWithExcel(string path)
        {
            var ExcelApp = new Excel.Application();
            ExcelApp.Workbooks.OpenText(path, Tab: true);

            ExcelApp.Visible = true;
        }
    }
}
