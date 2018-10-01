using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTimer : MonoBehaviour {

    float countdown;

    // Use this for initialization
    void Start () {
        countdown = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if (countdown <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
