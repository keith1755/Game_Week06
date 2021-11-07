using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _passwordSys : MonoBehaviour
{
    public GameObject k1, k2, k3;
    public int p1, p2, p3;
    public int _p1, _p2, _p3;

    void Start()
    {
        _p1 = Random.Range(1, 4);
        _p2 = Random.Range(1, 4);
        _p3 = Random.Range(1, 4);

    }

    void Update()
    {
        p1 = k1.GetComponent< _password>().p1;
        p2 = k2.GetComponent<_password>().p1;
        p3 = k3.GetComponent<_password>().p1;

        if (p1 == _p1 && p2==_p2 && p3 == _p3)
        {
            Debug.Log("unlock"); //Do something, audio, animation
        }
    }
}
