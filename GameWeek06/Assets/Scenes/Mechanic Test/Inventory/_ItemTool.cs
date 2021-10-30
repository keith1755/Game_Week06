using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Create ItemTool in the Inspector
[CreateAssetMenu(fileName = "NewItem", menuName = "Items Tool")]

//It means that our ItemTool can do anything an Item can do, and has all of its properties
//so these ItemTool have a name and icon
//They also have access to the Use() method(override)
public class _ItemTool : _GameItem
{
    public _GameItem item;
    public int heal = 0;


    public override void use()
    {
        GameObject player = _PlayerInventory.instance.player;
        Debug.Log("use item");

        _PlayerInventory.instance.Remove(this);
    }
}