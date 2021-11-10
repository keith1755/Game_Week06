using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Loading : MonoBehaviour
{
    public float time = 5f;
    public GameObject PlayButton;
    public GameObject PlayCam;
    public GameObject Speed;



    void Start()
    {
        Time.timeScale = 1;
        Speed.GetComponent<_K_playerControl>()._speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            time = 0;
         
            PlayButton.SetActive(true);
        }
    }

    //play button click function
    public void PlayGame()
    {
        PlayCam.SetActive(true);
        Speed.GetComponent<_K_playerControl>()._speed = 10f;
        Speed.GetComponent<_PlayerSys>().GameStart = true;


        Destroy(gameObject);
    }
}
