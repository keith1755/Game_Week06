using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class _Finish : MonoBehaviour
{
    public GameObject inventoryBag;
    public GameObject[] collection;
    public TMP_Text itemDescription;

    void Start()
    {
        
    }


    void Update()
    {
        if(inventoryBag.GetComponent<_PlayerInventory>().ankh == true)
        {
            collection[0].SetActive(true);
        }
        if (inventoryBag.GetComponent<_PlayerInventory>().CanJar == true)
        {
            collection[1].SetActive(true);
        }
        if (inventoryBag.GetComponent<_PlayerInventory>().CatStat == true)
        {
            collection[2].SetActive(true);
        }
        if (inventoryBag.GetComponent<_PlayerInventory>().KhoShi == true)
        {
            collection[3].SetActive(true);
        }
        if (inventoryBag.GetComponent<_PlayerInventory>().PharahoHead == true)
        {
            collection[4].SetActive(true);
        }
        if (inventoryBag.GetComponent<_PlayerInventory>().Scarab == true)
        {
            collection[5].SetActive(true);
        }
        if (inventoryBag.GetComponent<_PlayerInventory>().StickFia == true)
        {
            collection[6].SetActive(true);
        }
        if (inventoryBag.GetComponent<_PlayerInventory>().Snake == true)
        {
            collection[7].SetActive(true);
        }
    }

    public void Item1()
    {
        itemDescription.text = "Ankh - The ：Key of Life； was carried as an amulet to make sure the buried had eternal life, health and strength.";
    }

    public void Item2()
    {
        itemDescription.text = "Canopic Jars - Vessels that contained the organs that are removed during mummification. Each jar was seen as being protected by the god shown on the lid, so that the Pharoah・s insides were safe for the journey to the afterlife.";
    }

    public void Item3()
    {
        itemDescription.text = "Cat Statue - Cats were considered sacred to Egyptians with multiple deities having cat - like heads.The felines were seen as protectors of kings as well as bringers of good energy.";
    }

    public void Item4()
    {
        itemDescription.text = "Khopesh and Shield - A sickle-liked shaped weapon and defensive shield. Hieroglyphs depict Pharaohs using these in battles to smite their enemies in close combat.";
    }

    public void Item5()
    {
        itemDescription.text = "Nemes - A cloth headdress worn by Pharoahs. King Tut・s casket shows his headpiece as it signifies leaving the physical life and beginning the spiritual afterlife.";
    }

    public void Item6()
    {
        itemDescription.text = "Crook and Flail - The only known representation of these symbols remaining is on Tutankhamen・s sarcophagus, the props represent power, kingship and guidance.";
    }

    public void Item7()
    {
        itemDescription.text = "Uraeus Adornment - A part of the burial headdress that Tut wore, the cobra relates to the serpent goddess, Wadjet - the patron god of Lower Egypt. Wearing this represented the unification of upper and lower Egypt under royalty. ";
    }

    public void Item8()
    {
        itemDescription.text = "Scarab Bettle - An insect that often represented as a symbol of immortality, resurrection and protection. Pharaohs were often buried with scarab amulets to protect them in the afterlife and ensure they are reincarnated.";
    }
}
