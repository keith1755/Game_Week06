using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerSys : MonoBehaviour
{
    public int bomb;
    public GameObject breakParticle, hit;

    public Transform SpawnPos;

    public float timer;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void Gethit()
    {
        gameObject.transform.position = new Vector3(SpawnPos.position.x, SpawnPos.position.y, SpawnPos.position.z);
    }

    public void AddBomb()
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

    void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.collider.tag == "Trap")
        {
            Gethit();
        }

    }

    void GameOver()
    {

    }

}
