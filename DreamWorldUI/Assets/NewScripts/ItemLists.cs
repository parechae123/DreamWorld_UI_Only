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
{                               //+������ �ε���
    public string ItemName;     //������ �̸�
    public ItemTypes itemType;  //������ Ÿ��
    public string iconPath;     //������ �ڵ�
    public string modelingPath; //�𵨸� �н�
    public string itemMatPath;  //���׸��� �н�
    public int ItemAmount;      //�������� ����
    public int ingredientItem;  //�������� �ڵ�1
    public int ingredientItem2; //�������� �ڵ�2
    public int ingredientItem3; //�������� �ڵ�3
    public int ingredientItemAmount;  //1�� �������� ����1
    public int ingredientItemAmount2; //2�� �������� ����2
    public int ingredientItemAmount3; //3�� �������� ����3
}
