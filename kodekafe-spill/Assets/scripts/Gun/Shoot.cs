﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bullet;
    public Transform firePoint;
    public AudioSource shootSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, firePoint.position, transform.rotation);
            shootSound.Play();
        }
    }
}