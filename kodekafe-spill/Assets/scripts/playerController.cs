using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody rb;

    public float speed = 6f;
    public float jump = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
}
