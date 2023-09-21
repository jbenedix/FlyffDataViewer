using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using FlyffDataViewer.DTOs;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace FlyffDataViewer.Classes
{
    public static class ContentManager
    {
        public static List<SpecItem> Items = new List<SpecItem>();
        public static List<PropItemDescription> ItemsDescription = new List<PropItemDescription>();
        public static List<DefineItem> defineItems = new List<DefineItem>();
        public static List<SpecItem> SpecItems = new List<SpecItem>();

        public static List<string> propitemtxt = new List<string>();
        public static List<string> propitemtxttxt = new List<string>();
        public static List<string> SpecItemtxt = new List<string>();
        public static List<string> ShopList = new List<string>();


        public static void LoadItems()
        {
            LoadSpecItemTxt();
            LoadPropItemTxtTxt();
            LoadDefineItems();
            updateItemIngameName();

        }


        public static void LoadSpecItemTxt()
        {
            //Load propitem.txt
            propitemtxt = File.ReadAllLines(SettingsManager.resourcePath + "\\Spec_Item.txt").ToList();
            propitemtxt = propitemtxt.Distinct().ToList();
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
            for (int i = 0; i < propitemtxt.Count; i++)
            {
                if (propitemtxt[i].Contains("dwID") && propitemtxt[i].Contains("szName"))
                {
                    headlineNumber = i;
                }
            }

            //Find Indexes:
            var temp = propitemtxt[headlineNumber].Split('\t');
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
            for (int i = headlineNumber + 1; i < propitemtxt.Count; i++)
            {
                var test = propitemtxt[i].Split('\t').Length;
                Console.WriteLine(test);
                if (propitemtxt[i].Split('\t').Length == 171)
                {
                    var splittedLine = propitemtxt[i].Split('\t');
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
                Console.WriteLine(Items);

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
                    var propitemtxttxtObject = new PropItemDescription
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
