using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour {

    public static bool isInRange;
    public bool test;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            isInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isInRange = false;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
