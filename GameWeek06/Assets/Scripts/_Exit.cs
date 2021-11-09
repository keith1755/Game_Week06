using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Exit : MonoBehaviour
{
    private GameObject FinishUI;

    void Start()
    {
        FinishUI = GameObject.Find("FinishUI");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FinishUI.SetActive(true);
            Time.timeScale = 0;
        }
    }


}
