using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _K_RoomBehaviour : MonoBehaviour
{
    //0-Up, 1-Down, 2-Rigjt, 3-Left
    public GameObject[] walls;
    public GameObject[] doors;


    public void UpdateRoom(bool[] status)
    {
        for(int i=0; i < status.Length; i++)
        {
            doors[i].SetActive(status[i]);
            walls[i].SetActive(!status[i]);
        }
    }
}
