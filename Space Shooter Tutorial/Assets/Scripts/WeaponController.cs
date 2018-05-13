using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    // time between shots
    public float fireRate;
    // don't have ship fire immediately at beginning of game
    public float delay;
    private AudioSource audioSource;

	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        // this is the built in function instead of creating a co-routine
        InvokeRepeating("Fire", delay, fireRate);
	}

    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        audioSource.Play();
    }
}
