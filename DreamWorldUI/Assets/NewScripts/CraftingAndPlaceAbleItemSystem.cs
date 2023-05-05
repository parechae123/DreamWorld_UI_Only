using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingAndPlaceAbleItemSystem : ItemLists
{
    protected void ItemCrafting(int craftingTargetItemNumber)               //���� ��ǥ �������� �ε����� �޾Ƽ�
    {
        int a = ItemDictionary[craftingTargetItemNumber].ingredientItem;    //���� ��ǥ �������� ��� �ε����� abc�� ����
        int b = ItemDictionary[craftingTargetItemNumber].ingredientItem2;
        int c = ItemDictionary[craftingTargetItemNumber].ingredientItem3;
        if (a != 0 && b != 0 && c != 0)//�������� �������ڵ� �к�
        {
            Debug.Log("��ᰡ ������?");
            if (ItemDictionary[a].ItemAmount > ItemDictionary[craftingTargetItemNumber].ingredientItemAmount && ItemDictionary[b].ItemAmount > ItemDictionary[craftingTargetItemNumber].ingredientItemAmount2 && ItemDictionary[c].ItemAmount > ItemDictionary[craftingTargetItemNumber].ingredientItemAmount3)
            {//���� �κ��丮�� �������� �ʿ� �������� ������ ���۰� �Ҹ� �ȵǵ��� ¥���� �ڵ�
                ItemDictionary[craftingTargetItemNumber].ItemAmount += 1;       //���� ��ǥ ������ �������� �ϳ� ������(����)
                ItemDictionary[a].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount;                              //���������� �������� 1���� ��
                ItemDictionary[b].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount2;
                ItemDictionary[c].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount3;
            }
        }
        else if (a != 0 && b != 0)
        {
            Debug.Log("��ᰡ �ΰ���?");
            if (ItemDictionary[a].ItemAmount > 0 && ItemDictionary[b].ItemAmount > 0)
            {
                ItemDictionary[craftingTargetItemNumber].ItemAmount += 1;
                ItemDictionary[a].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount;                              //���������� �������� 1���� ��
                ItemDictionary[b].ItemAmount -= ItemDictionary[craftingTargetItemNumber].ingredientItemAmount2;
            }
        }
        else if (a != 0)
        {
            Debug.Log("��ᰡ �Ѱ���?");
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
