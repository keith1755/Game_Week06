using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GameItem : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;

    //This function uses the keyword virtual this allows each Item type to overwrite this function
    public virtual void use()
    {

    }
}


