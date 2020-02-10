using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public bool automatic;
    public int ammo;
    private int currentAmmo;
    public float fireRate;
    private float nextTimeToFire = 0f;

    public float upRecoil;
    public float sideRecoil;
    public mouseLook mouseLook;

    public GameObject bullet;
    public Transform firePoint;
    public AudioSource shootSound;
    public ParticleSystem muzzleFlash;

    public KeyCode reloadKey = KeyCode.R;

    // Update is called once per frame
    void Update()
    {
        if (automatic && Input.GetButton("Fire1") && Time.time >= nextTimeToFire && ammo > 0)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            ammo--;
            Shoot();
        }
        if (!automatic && Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire && ammo > 0)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            ammo--;
            Shoot();
        }

        if (Input.GetKeyDown(reloadKey))
        {
            Reload();
        }
    }

    private void Shoot()
    {
        Instantiate(bullet, firePoint.position, transform.rotation);
        shootSound.Play();
        muzzleFlash.Play();
        mouseLook._upRecoil = upRecoil;
        mouseLook._sideRecoil = sideRecoil;
    }

    void Reload()
    {
        currentAmmo = ammo;
    }
}
