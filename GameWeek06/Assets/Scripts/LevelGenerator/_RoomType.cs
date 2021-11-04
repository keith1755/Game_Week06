using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _RoomType : MonoBehaviour
{
    public int type;

    public void RoomDestruction()
    {
        Destroy(gameObject);
    }

}
