using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerInventory : MonoBehaviour
{
    public List<_GameItem> list = new List<_GameItem>();

    public GameObject player;
    public GameObject inventoryPanel;

    public static _PlayerInventory instance;


    //updating inventory panel info by checking each slot which has the k_inventorySlot... component
    void UpdatePanelSlots()
    {
        int index = 0;
        foreach (Transform child in inventoryPanel.transform)
        {
            _GameInventoryController slot = child.GetComponent<_GameInventoryController>();
            if (index < list.Count)
            {
                slot.item = list[index];
            }
            else
            {
                slot.item = null;
            }

            slot.updateInfo();
            index++;
        }
    }

    //Adding item into the inventory
    public void Add(_GameItem item)
    {
        if (list.Count < 8)
        {
            list.Add(item);
        }
        UpdatePanelSlots();
    }

    //Removing item from the inventory
    public void Remove(_GameItem item)
    {
        list.Remove(item);
        UpdatePanelSlots();
    }


    void Start()
    {
        //Now any script can write Inventory.instance and refer to the one and only inventory
        instance = this;
        UpdatePanelSlots();
    }

    public void CheckItem()
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].name == "GoldenHead")
            {
                
            }
        }
    }

    void Update()
    {
        CheckItem();
    }
}
