using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

    public static bool dead;
    public Rigidbody rb;

    // Use this for initialization
    void Update () {
		if (this.transform.position.y < -10)
        {
            dead = true;
            rb.angularVelocity = Vector3.zero;
            rb.velocity = Vector3.zero;
        }
        else
        {
            dead = false;
        }
	}
}
