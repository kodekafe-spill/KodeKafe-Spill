using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bullet;
    public Transform firePoint;
    public AudioSource shootSound;
    public ParticleSystem muzzleFlash;

    bool isPaused = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, firePoint.position, transform.rotation);
            shootSound.Play();
            muzzleFlash.Play();
        }
    }
}
