using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _RestLevelSpawn : MonoBehaviour
{
    public LayerMask whatIsRoom;
    public _LevelGenerator levelGen;

    void Update()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity, whatIsRoom);
        {
            if (hit.collider == null && levelGen.stopGeneration == true)
            {
                int rand = Random.Range(4, levelGen.rooms.Length);
                Instantiate(levelGen.rooms[rand], transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }



    }
}
