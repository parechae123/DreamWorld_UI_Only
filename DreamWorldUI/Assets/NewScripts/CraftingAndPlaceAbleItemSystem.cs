using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingAndPlaceAbleItemSystem : ItemLists
{
    protected void ItemCrafting(int craftingTargetItemNumber)               //제작 목표 아이템의 인덱스를 받아서
    {
        int a = ItemDictionary[craftingTargetItemNumber].ingredientItem;    //제작 목표 아이템의 재료 인덱스를 abc에 대입
        int b = ItemDictionary[craftingTargetItemNumber].ingredientItem2;
        int c = ItemDictionary[craftingTargetItemNumber].ingredientItem3;
        if (a != 0 && b != 0 && c != 0)//재료아이템 아이템코드 분별
        {
            Debug.Log("재료가 세개라구?");
            if (ItemDictionary[a].ItemAmount > ItemDictionary[craftingTargetItemNumber].ingredientItemAmount && ItemDictionary[b].ItemAmount > ItemDictionary[craftingTargetItemNumber].ingredientItemAmount2 && ItemDictionary[c].ItemAmount > ItemDictionary[craftingTargetItemNumber].ingredientItemAmount3)
            {//대충 인벤토리에 아이템이 필요 갯수보다 적으면 재작과 소모가 안되도록 짜놓은 코드
                ItemDictionary[craftingTargetItemNumber].ItemAmount += 1;       //제작 목표 아이템 아이템을 하나 더해줌(제작)
                ItemDictionary[a].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount;                              //재료아이템의 갯수에서 1개를 뺌
                ItemDictionary[b].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount2;
                ItemDictionary[c].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount3;
            }
        }
        else if (a != 0 && b != 0)
        {
            Debug.Log("재료가 두개라구?");
            if (ItemDictionary[a].ItemAmount > 0 && ItemDictionary[b].ItemAmount > 0)
            {
                ItemDictionary[craftingTargetItemNumber].ItemAmount += 1;
                ItemDictionary[a].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount;                              //재료아이템의 갯수에서 1개를 뺌
                ItemDictionary[b].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount2;
            }
        }
        else if (a != 0)
        {
            Debug.Log("재료가 한개라구?");
            if (ItemDictionary[a].ItemAmount > 0)
            {
                ItemDictionary[craftingTargetItemNumber].ItemAmount += 1;       
                ItemDictionary[a].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount;
            }
        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ItemCrafting(00020);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            ItemCrafting(00021);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ItemCrafting(00022);
        }
    }
}
