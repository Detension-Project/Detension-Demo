using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///
///</summary>
public class CameraController : MonoBehaviour
{
    private float MouseX;
    private float MouseY;
    public float XMouseSensitivity;
    public float YMouseSensitivity;
    public Transform playerTransform;

    private void Update()
    {
        MouseX = Input.GetAxis("Mouse X") * Time.deltaTime * XMouseSensitivity;
        MouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * YMouseSensitivity;


        playerTransform.Rotate(Vector3.up * MouseX);
        if(-160 < transform.rotation.x && transform.rotation.x < 160)
        {
            transform.Rotate(-Vector3.right * MouseY);
        }
    }
}
