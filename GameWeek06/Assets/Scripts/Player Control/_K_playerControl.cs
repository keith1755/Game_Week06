using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _K_playerControl : MonoBehaviour
{

    public float _speed = 10f;
    public float _jump = 10f;

    public float _gravity = -9.81f;
    Vector3 _velocity;
    bool isGround;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;



    public CharacterController _controller;

    void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }


    private void Update()
    {
        isGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
            if(isGround && _velocity.y < 0)
        {
            _velocity.y = -2.0f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        _controller.Move(move * _speed * Time.deltaTime);

        _velocity.y += _gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGround)
        {
            _velocity.y = Mathf.Sqrt(_jump * -2f * _gravity);
        }
    }

}
