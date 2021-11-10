using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class _ItemPickUp : MonoBehaviour
{
    public _ItemTool item;

    //PlayerUI text
    public TMP_Text displayText;
    bool interact;

    public void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "Player")
        {
            transform.LookAt(other.transform);
            displayText.text = item.itemName;
            interact = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            displayText.text = " ";
            interact = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interact)
        {
            Debug.Log("get item");

            _PlayerInventory.instance.Add(item);
            Destroy(this.gameObject);
            displayText.text = " ";
        }
    }
}
