using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _passwordSys : MonoBehaviour
{
    public GameObject k1, k2, k3;
    private int p1, p2, p3;
    private int _p1, _p2, _p3;

    public GameObject[] hint;
    public Transform H1, H2, H3;

    public GameObject Door, particle;
    public Transform particlePos;

    bool unlock;

    void Start()
    {
        unlock = true;
        _p1 = Random.Range(1, 4);
        _p2 = Random.Range(1, 4);
        _p3 = Random.Range(1, 4);

        int _H1 = _p1 - 1;
        int _H2 = _p2 - 1;
        int _H3 = _p3 - 1;

        Instantiate(hint[_H1], H1.transform.position, H1.transform.rotation);
        Instantiate(hint[_H2], H2.transform.position, H2.transform.rotation);
        Instantiate(hint[_H3], H3.transform.position, H3.transform.rotation);

    }

    void Update()
    {
        p1 = k1.GetComponent< _password>().p1;
        p2 = k2.GetComponent<_password>().p1;
        p3 = k3.GetComponent<_password>().p1;

        if (p1 == _p1 && p2==_p2 && p3 == _p3)
        {
            DoorOpen();
        }

        
    }

    void DoorOpen()
    {
        if(unlock == true)
        {
            Instantiate(particle, particlePos.transform.position, particlePos.transform.rotation);
            Destroy(Door);
            unlock = false;
        }
    }
}
