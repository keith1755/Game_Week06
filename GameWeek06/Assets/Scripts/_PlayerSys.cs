using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerSys : MonoBehaviour
{
    public int life;
    public int bomb;
    public GameObject breakParticle, hit;


    //public GameObject invertoryBag;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void Gethit()
    {
        life -= 1;

    }

    void AddBomb()
    {
        bomb += 1;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Door")
        {
            Debug.Log("Door");
            if(bomb >= 1)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    bomb -= 1;
                    Instantiate(breakParticle, other.transform.position, Quaternion.identity);
                    Destroy(other.gameObject);
                }
            }
        } 
    }

    void GameOver()
    {

    }

    void Escape()
    {
        
    }


}
