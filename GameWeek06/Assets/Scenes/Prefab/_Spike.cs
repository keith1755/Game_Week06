using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Spike : MonoBehaviour
{
    public float StartTime;
    public float speed;

    public float _height;

    private Vector3 StartPosition;


    void Start()
    {
        StartPosition = transform.position;
    }


    void Update()
    {
        SpikeTrap();

    }


    void SpikeTrap()
    {
        transform.position = new Vector3(transform.position.x, StartPosition.y + _height * Mathf.Sin((StartTime + Time.time) * speed), transform.position.z);
    }
}

