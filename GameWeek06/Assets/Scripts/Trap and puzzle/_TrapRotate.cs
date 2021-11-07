using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _TrapRotate : MonoBehaviour
{
    public float timer;
    private float currentTime;
    public GameObject slope;
    public bool active;

    public GameObject stone;
    public Transform spawnPos;

    void Start()
    {
        currentTime = timer;
    }

    
    void Update()
    {
        if (active)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {

                Instantiate(stone, spawnPos.position, spawnPos.rotation);
                slope.transform.eulerAngles = new Vector3(slope.transform.eulerAngles.x, slope.transform.eulerAngles.y + 90, slope.transform.eulerAngles.z);
                currentTime = timer;
            }
        }

    }

}
