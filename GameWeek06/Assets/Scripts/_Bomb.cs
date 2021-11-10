using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class _Bomb : MonoBehaviour
{
    public TMP_Text displayText;

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.LookAt(other.transform);
            displayText.text = "Bomb";

            if (Input.GetKeyDown(KeyCode.E))
            {
                other.GetComponent<_PlayerSys>().AddBomb();
                Destroy(gameObject);
            }
            
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            displayText.text = " ";
        }
    }
}
