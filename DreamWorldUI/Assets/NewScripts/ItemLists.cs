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
        { 000001, new ItemValues{ ItemName = "Name", itemType = ItemTypes.equipment,iconPath = "Path" ,ItemAmount = 0 ,modelingPath = "ModelingPath",itemMatPath = "MaterialPath"} },
        { 000002, new ItemValues{ ItemName = "Name", itemType = ItemTypes.equipment,iconPath = "Path" ,ItemAmount = 0 ,modelingPath = "ModelingPath",itemMatPath = "MaterialPath"} },
        { 000003, new ItemValues{ ItemName = "Name", itemType = ItemTypes.equipment,iconPath = "Path" ,ItemAmount = 0 ,modelingPath = "ModelingPath",itemMatPath = "MaterialPath"} },
        { 000010, new ItemValues{ ItemName = "Name", itemType = ItemTypes.ingredient,iconPath = "Path" ,ItemAmount = 0 } },
        { 000011, new ItemValues{ ItemName = "Name", itemType = ItemTypes.ingredient,iconPath = "Path" ,ItemAmount = 0 } },
        { 000012, new ItemValues{ ItemName = "Name", itemType = ItemTypes.ingredient,iconPath = "Path" ,ItemAmount = 0 } },
        { 000013, new ItemValues{ ItemName = "Name", itemType = ItemTypes.ingredient,iconPath = "Path" ,ItemAmount = 0 } },
        { 000020, new ItemValues{ ItemName = "Name", itemType = ItemTypes.PlaceAble,iconPath = "Path" ,ItemAmount = 0 } },
        { 000021, new ItemValues{ ItemName = "Name", itemType = ItemTypes.PlaceAble,iconPath = "Path" ,ItemAmount = 0 } },
        { 000022, new ItemValues{ ItemName = "Name", itemType = ItemTypes.PlaceAble,iconPath = "Path" ,ItemAmount = 0 } },
        { 000023, new ItemValues{ ItemName = "Name", itemType = ItemTypes.PlaceAble,iconPath = "Path" ,ItemAmount = 0 } },
    };
}

public class ItemValues
{
    public string ItemName;
    public ItemTypes itemType;
    public string iconPath;
    public string modelingPath;
    public string itemMatPath;
    public int ItemAmount;
}
