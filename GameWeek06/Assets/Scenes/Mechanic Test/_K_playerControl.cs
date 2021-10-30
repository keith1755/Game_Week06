using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _K_playerControl : MonoBehaviour
{
    public float speed;
    private Vector3 PlayerMove;
    public CharacterController _PlayerControl;




    void Awake()
    {

    }

    void Start()
    {
        _PlayerControl = GetComponent<CharacterController>();

    }


    void Update()
    {
        PlayerMove = Vector3.zero;

        PlayerMove.z = Input.GetAxisRaw("Vertical")*speed;
        PlayerMove.x = Input.GetAxisRaw("Horizontal")*speed;

        _PlayerControl.Move((PlayerMove) * Time.deltaTime);

    }
}
