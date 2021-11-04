using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _LevelGenerator : MonoBehaviour
{
    public Transform[] startPos;
    public GameObject[] rooms; // 0-LR, 1-LRB, 2-LRT, 3-4, 4-other
    public GameObject exit;

    private int direction;
    public float moveAmount;

    private float timeBtwRoom;
    public float startTimeBtwRoom = 0.25f;

    public float minX;
    public float maxX;
    public float minZ;
    public bool stopGeneration;

    public LayerMask room;

    private int downCounter;


    private void Start()
    {
        int randStartingPos = 0;
        transform.position = startPos[randStartingPos].position;
        Instantiate(rooms[2], transform.position, Quaternion.identity);

        direction = Random.Range(1, 6);
    }

    private void Move()
    {
        //Debug.Log(direction);
        if (direction == 1 || direction == 2)
        {
            //move right
            downCounter = 0;
            if (transform.position.x < maxX)
            {
                Vector3 newPos = new Vector3(transform.position.x + moveAmount, 0, transform.position.z);
                transform.position = newPos;

                int rand = Random.Range(0, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);


                direction = Random.Range(1, 6);
                if (direction == 3)
                {
                    direction = 2;
                }
                else if (direction == 4)
                {
                    direction = 5;
                }
            }
            else { direction = 5; }
        }

        else if (direction == 3 || direction == 4)
        {
            //move Left
            downCounter = 0;
            if (transform.position.x > minX)
            {
                Vector3 newPos = new Vector3(transform.position.x - moveAmount, 0, transform.position.z);
                transform.position = newPos;

                int rand = Random.Range(0, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);

                direction = Random.Range(3, 6);
            }
            else { direction = 5; }

        }

        else if (direction == 5)
        {
            //move Down

            downCounter++;
            if (transform.position.z > minZ)
            {
                RaycastHit hit;
                Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity, room);
                if (hit.collider.gameObject.GetComponent<_RoomType>().type != 1 && hit.collider.gameObject.GetComponent<_RoomType>().type != 3)
                {
                    if (downCounter >= 1)
                    {
                        hit.collider.gameObject.GetComponent<_RoomType>().RoomDestruction();
                        Instantiate(rooms[3], transform.position, Quaternion.identity);
                    }
                    else
                    {
                        hit.collider.gameObject.GetComponent<_RoomType>().RoomDestruction();
                        int randBottomRoom = Random.Range(1, 4);
                        if (randBottomRoom == 2)
                        {
                            randBottomRoom = 1;
                        }
                        Instantiate(rooms[randBottomRoom], transform.position, Quaternion.identity);
                    }
                }

                Vector3 newPos = new Vector3(transform.position.x, 0, transform.position.z - moveAmount);
                transform.position = newPos;

                int rand = Random.Range(2, 3);
                Instantiate(rooms[rand], transform.position, Quaternion.identity);

                direction = Random.Range(1, 6);
            }
            else
            {
                Instantiate(exit, transform.position, Quaternion.identity);
                stopGeneration = true;
            }
        }
    }

    private void Update()
    {

        if (timeBtwRoom <= 0 && stopGeneration == false)
        {
            Move();
            timeBtwRoom = startTimeBtwRoom;
        }
        else
        {
            timeBtwRoom -= Time.deltaTime;
        }
    }
}
