using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PrefabWeapon : MonoBehaviour {

	public Transform firePoint;
	public GameObject bulletPrefab;
	public AudioSource sound;
	
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown("Fire1"))
		{
			Shoot();
		}
	}

	void Shoot ()
	{
		sound.Play();
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
}
