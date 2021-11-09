using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ItemSpawn : MonoBehaviour
{
    public Transform[] spawnPos;
    public GameObject[] item;

    void Start()
    {
        int _sp = Random.Range(0, spawnPos.Length);
        int _item = Random.Range(0, item.Length);

        Instantiate(item[_item], spawnPos[_sp].position, spawnPos[_sp].rotation);

    }

    
    void Update()
    {
        
    }
}
