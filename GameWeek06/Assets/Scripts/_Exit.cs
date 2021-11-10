using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Exit : MonoBehaviour
{

    void Start()
    {
       
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<_PlayerSys>().Escape = true;
        }
    }


}
