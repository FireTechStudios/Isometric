using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

    public KeyCode MyKey;
    public Rigidbody rb;
    public float thrust;

    public float groundedHeight = 0.5f; // the height above ground to determine if the player is grounded
    public bool grounded = false;// is grounded or not
    public LayerMask groundLayer;//the layer on which we can be grounded

    void GroundCheck()
    {
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y, transform.position.z), Vector3.down, groundedHeight, groundLayer))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    private void FixedUpdate()
    {
        GroundCheck();
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(MyKey))
        {
            StartCoroutine(Wait());
            if (grounded == true)
            {
                rb.AddForce(transform.up * thrust, ForceMode.Impulse);
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.02f);
    }

}
