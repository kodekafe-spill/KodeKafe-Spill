using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 8f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float sprintSpeed = 12f;
    public float walkSpeed = 8f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public Camera cam;

    private Vector3 currentSpeed;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -4f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = Vector3.zero;
        if (isGrounded)
        {
            move = transform.right * x + transform.forward * z;
            currentSpeed = move;
        }
        else move = currentSpeed;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        float newFov = GetComponent<fov>().FOV;
        float oldFov = GetComponent<fov>().FOV;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (isGrounded)
            {
                newFov += 20;                
                speed = sprintSpeed;
            }
        } else
        {
            oldFov -= 20;
            speed = walkSpeed;
        }
    }
}
