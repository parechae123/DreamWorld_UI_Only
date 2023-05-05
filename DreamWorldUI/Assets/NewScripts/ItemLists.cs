using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemTypes
{
    equipment, ingredient, PlaceAble
}
public class ItemLists : MonoBehaviour
{
    protected Dictionary<int/*ItemNumber*/, ItemValues> ItemDictionary = new Dictionary<int, ItemValues>()
    {
        { 00001, new ItemValues{ ItemName = "Log", itemType = ItemTypes.equipment,iconPath = "Path" ,ItemAmount = 0 ,modelingPath = "ModelingPath",itemMatPath = "MaterialPath"} },
        { 00002, new ItemValues{ ItemName = "lol", itemType = ItemTypes.equipment,iconPath = "Path" ,ItemAmount = 0 ,modelingPath = "ModelingPath",itemMatPath = "MaterialPath"} },
        { 00003, new ItemValues{ ItemName = "starc", itemType = ItemTypes.equipment,iconPath = "Path" ,ItemAmount = 0 ,modelingPath = "ModelingPath",itemMatPath = "MaterialPath"} },
        { 00010, new ItemValues{ ItemName = "warc", itemType = ItemTypes.ingredient,iconPath = "Path" ,ItemAmount = 0 } },
        { 00011, new ItemValues{ ItemName = "Name", itemType = ItemTypes.ingredient,iconPath = "Path" ,ItemAmount = 0 } },
        { 00012, new ItemValues{ ItemName = "Name", itemType = ItemTypes.ingredient,iconPath = "Path" ,ItemAmount = 0 } },
        { 00013, new ItemValues{ ItemName = "Name", itemType = ItemTypes.ingredient,iconPath = "Path" ,ItemAmount = 0 } },
        { 00020, new ItemValues{ ItemName = "Name", itemType = ItemTypes.PlaceAble,iconPath = "Path" ,ItemAmount = 0 ,ingredientItem = 00001,ingredientItem2 = 00002,ingredientItem3 = 00003,ingredientItemAmount =3,ingredientItemAmount2 = 3,ingredientItemAmount3 = 3} },
        { 00021, new ItemValues{ ItemName = "Name", itemType = ItemTypes.PlaceAble,iconPath = "Path" ,ItemAmount = 0 ,ingredientItem = 00001,ingredientItem2 = 00002,ingredientItemAmount =3,ingredientItemAmount2 = 3} },
        { 00022, new ItemValues{ ItemName = "Name", itemType = ItemTypes.PlaceAble,iconPath = "Path" ,ItemAmount = 0 ,ingredientItem = 00001,ingredientItemAmount = 3} },
        { 00023, new ItemValues{ ItemName = "Name", itemType = ItemTypes.PlaceAble,iconPath = "Path" ,ItemAmount = 0 } },
    };
}

public class ItemValues
{                               //+아이템 인덱스
    public string ItemName;     //아이템 이름
    public ItemTypes itemType;  //아이템 타입
    public string iconPath;     //아이콘 코드
    public string modelingPath; //모델링 패스
    public string itemMatPath;  //머테리얼 패스
    public int ItemAmount;      //재료아이템 갯수
    public int ingredientItem;  //재료아이템 코드1
    public int ingredientItem2; //재료아이템 코드2
    public int ingredientItem3; //재료아이템 코드3
    public int ingredientItemAmount;  //1번 재료아이템 갯수1
    public int ingredientItemAmount2; //2번 재료아이템 갯수2
    public int ingredientItemAmount3; //3번 재료아이템 갯수3
}
