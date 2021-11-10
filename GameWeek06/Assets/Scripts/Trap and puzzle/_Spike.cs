using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Spike : MonoBehaviour
{
    public float speed;

    public GameObject spikeGroup;

    public Vector3 StartPosition;

    bool moveDown;
    public bool loop, trigger;

    AudioSource _triggerSound;

    void Start()
    {
        StartPosition = spikeGroup.transform.position;
        _triggerSound = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (loop) {SpikeTrap();}
        SpikeTrap2();
    }

    void SpikeTrap()
    {

        if (!moveDown)
        {
            spikeGroup.transform.position = StartPosition + new Vector3(0, StartPosition.y += 1f * speed * Time.deltaTime, 0);
            if (StartPosition.y >= 1.5f)
            {
                moveDown = true;
            }

        }

        if (moveDown)
        {
            spikeGroup.transform.position = StartPosition + new Vector3(0, StartPosition.y -= 1f * speed * Time.deltaTime, 0);
            if (StartPosition.y <= -1f)
            {
                moveDown = false;
            }
        }
            
    }

    void SpikeTrap2()
    {
        if (trigger || moveDown == true)
        {
            if (!moveDown)
            {
                spikeGroup.transform.position = StartPosition + new Vector3(0, StartPosition.y += 1f * speed * Time.deltaTime, 0);
                if (StartPosition.y >= 1.5f)
                {
                    moveDown = true;
                }

            }

            if (moveDown)
            {
                spikeGroup.transform.position = StartPosition + new Vector3(0, StartPosition.y -= 1f * speed * Time.deltaTime, 0);
                if (StartPosition.y <= -1f)
                {
                    moveDown = false;
                    trigger = false;
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (!loop)
            {
                _triggerSound.Play();
            }
            
            trigger = true;
        }
    }

}

