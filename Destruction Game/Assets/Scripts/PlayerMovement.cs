using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody player;
    public float originalSpeed;
    private float speed;

    private void Start()
    {
        speed = originalSpeed;
    }

    void FixedUpdate()
    {
        var moveDirection = new Vector3(Input.GetAxisRaw("Horizontal")/2, 0, Input.GetAxisRaw("Vertical"));
        moveDirection = Camera.main.transform.TransformDirection(moveDirection);
        moveDirection.y = 0;


        player.MovePosition(player.position + moveDirection * speed * Time.deltaTime);
    }

}
