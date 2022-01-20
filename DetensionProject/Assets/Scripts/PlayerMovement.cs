using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///
///</summary>
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Vector3 movement;

    private void Update()
    {
        movement.z = Input.GetAxis("Vertical");
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Jump");
        transform.position += transform.forward * movement.z * speed * Time.deltaTime;
        transform.position += transform.right * movement.x * speed * Time.deltaTime;
    }
}
