using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _RoomSpawn : MonoBehaviour
{
    public Transform[] roomPos;
    public List<GameObject> rooms = new List<GameObject>();
    private bool finish = false;

    public void Start()
    {

    }

    public void Update()
    {
        StartCoroutine(RoomGen());


        if (rooms.Count == 0)
        {
            finish = true;
        }

    }

    IEnumerator RoomGen()
    {
        yield return new WaitForSeconds(4);
        if (!finish)
        {
            for (int i = 0; i < roomPos.Length; i++)
            {
                int rand = Random.Range(0, rooms.Count);
                {
                    Instantiate(rooms[rand], roomPos[i].position, Quaternion.identity);
                    rooms.RemoveAt(rand);
                }
            }
        }
    }
}
