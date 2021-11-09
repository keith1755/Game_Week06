using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class _password : MonoBehaviour
{

    public int p1 = 1;
    public GameObject passwordBox;
    public bool player;
    AudioSource _Audio;

    void Start()
    {
        _Audio = GetComponent<AudioSource>();
        player = false;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Showing text
            player = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player = false;
        }
        
    }

    void Update()
    {
        if (player)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _Audio.Play();
                p1 += 1;
                if (p1 >= 5)
                {
                    p1 = 1;
                }
            }
        }

        if (p1 == 1)
        {
            passwordBox.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (p1 == 2)
        {
            passwordBox.transform.rotation = Quaternion.Euler(90, 0, 0);
        }

        if (p1 == 3)
        {
            passwordBox.transform.rotation = Quaternion.Euler(180, 0, 0);
        }

        if (p1 == 4)
        {
            passwordBox.transform.rotation = Quaternion.Euler(270, 0, 0);
        }

    }


}
