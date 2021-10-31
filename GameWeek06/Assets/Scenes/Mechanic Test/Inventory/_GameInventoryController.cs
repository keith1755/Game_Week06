using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Applies this script to the UI slot 
public class _GameInventoryController : MonoBehaviour
{

    public _GameItem item;
    public TMP_Text displayText;
    public Image diaplayImage;

    public void use()
    {
        //Assign a function to run when clicked (on click button)
        if (item)
        {
            //the use() actually calling the item type script "override use()";
            Debug.Log("You clicked: " + item.itemName);
            item.use();
            
        }
    }

    //Updating text and image 
    public void updateInfo()
    {

        if (item)
        {
            displayText.text = item.itemName;
            diaplayImage.sprite = item.itemImage;
        }
        else
        {
            displayText.text = "";
            diaplayImage.sprite = null;
        }
    }

    public void Start()
    {
        updateInfo();
    }
}
