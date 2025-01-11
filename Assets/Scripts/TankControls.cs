using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    private float movement;
    private float rotation;
    private Rigidbody rb;
    public float jumpForce = 10f;

    private void Update()
    {
        movement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        rb = GetComponent<Rigidbody>();

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

    }

    private void LateUpdate()
    {
        transform.Translate(Vector3.forward * movement);
        transform.Rotate(0f, rotation, 0f);
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }


}
