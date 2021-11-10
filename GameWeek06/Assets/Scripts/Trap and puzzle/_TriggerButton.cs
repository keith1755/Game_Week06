using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _TriggerButton : MonoBehaviour
{
    public GameObject trap;
    AudioSource _triggerSound;


    void Start()
    {
        _triggerSound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _triggerSound.Play();
            trap.GetComponent<_TrapRotate>().active = true;
        }
    }



}
