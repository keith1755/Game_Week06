using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _TriggerButton : MonoBehaviour
{
    public GameObject trap;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("player");
            trap.GetComponent<_TrapRotate>().active = true;
        }
    }



}
