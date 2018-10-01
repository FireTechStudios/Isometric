using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrower : MonoBehaviour {

    public float throwForce = 25f;
    public Vector3 spawnLocation;
    public float spawnLocationX;
    public float spawnLocationY;
    public float spawnLocationZ;
    public Quaternion spawnRotation;
    public GameObject grenadePrefab;

	// Update is called once per frame
	void Update () {
        spawnLocationX = transform.position.x + 0.5f;
        spawnLocationY = transform.position.y;
        spawnLocationZ = transform.position.z;

        spawnLocation = new Vector3(spawnLocationX, spawnLocationY, spawnLocationZ);

        spawnRotation = Quaternion.Euler(0, 45f, 0);

        if (Input.GetMouseButton(0))
        {
            ThrowGrenade();
        }

	}

    void ThrowGrenade()
    {
        GameObject grenade = Instantiate(grenadePrefab, spawnLocation, spawnRotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce);
    }
}
