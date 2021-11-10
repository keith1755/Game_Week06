using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerInventory : MonoBehaviour
{
    public List<_GameItem> list = new List<_GameItem>();

    public GameObject player;
    public GameObject inventoryPanel;

    public static _PlayerInventory instance;

    public bool ankh, CanJar, CatStat, KhoShi, PharahoHead, Scarab, StickFia, Snake;

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
            if (list[i].name == "Ankh")
            {
                ankh = true;
            }
            if (list[i].name == "CanopicJars")
            {
                CanJar = true;
            }
            if (list[i].name == "Cat Statue")
            {
                CatStat = true;
            }
            if (list[i].name == "Khopesh Shield")
            {
                KhoShi = true;
            }
            if (list[i].name == "Pharaoh_Headdress")
            {
                PharahoHead = true;
            }
            if (list[i].name == "Scarab_Charm")
            {
                Scarab = true;
            }
            if (list[i].name == "Sickle_Flail")
            {
                StickFia = true;
            }
            if (list[i].name == "Snake")
            {
                Snake = true;
            }
        }
    }

    void Update()
    {
        CheckItem();
    }
}
