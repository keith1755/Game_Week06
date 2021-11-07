using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Stone : MonoBehaviour
{
    //public GameObject effect;

    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Wall" || other.collider.tag == "Door" || other.collider.tag == "Player" || other.collider.tag == "Trap")
        {
            Destroy(gameObject);
        }
    }
}
