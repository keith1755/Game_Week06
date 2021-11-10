using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Hidden : MonoBehaviour
{

    public GameObject inventoryBag;
    public GameObject Door;
    public GameObject unlockSound;
    public GameObject _Text;


    void Start()
    {
        inventoryBag = GameObject.Find("UI Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        if (inventoryBag.GetComponent<_PlayerInventory>().PharahoHead == true && inventoryBag.GetComponent<_PlayerInventory>().CatStat == true && inventoryBag.GetComponent<_PlayerInventory>().ankh == true && inventoryBag.GetComponent<_PlayerInventory>().StickFia == true)
        {
            Door.SetActive(false);
            unlockSound.SetActive(true);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inventoryBag.GetComponent<_PlayerInventory>().KingTut = true;
            _Text.SetActive(true);
        }
    }
}
