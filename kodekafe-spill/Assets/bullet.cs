using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), 1f))
        {
            Destroy(gameObject);
        }
    }
}
