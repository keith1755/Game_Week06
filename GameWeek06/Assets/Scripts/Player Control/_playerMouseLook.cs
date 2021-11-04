using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _playerMouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    float xRotateion = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotateion -= mouseY;
        xRotateion = Mathf.Clamp(xRotateion, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotateion, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
        //playerBody.Rotate(Vector3. * mouseX);

    }
}
