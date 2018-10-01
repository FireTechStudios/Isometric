using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSetter : MonoBehaviour
{
    public Transform player;
    public GameObject indicatorParticles;
    public int checkpointNumberManual;
    public static int largestCheckpointNumber;
    private bool hasBeenTriggered;
    private bool touchingCheckpoint;

    // Use this for initialization
    void Start()
    {
        largestCheckpointNumber = 1;
        indicatorParticles.SetActive(false);
        hasBeenTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (touchingCheckpoint == true)
        {
            hasBeenTriggered = true;
        }

        if(hasBeenTriggered == true && checkpointNumberManual >= CheckpointSetter.largestCheckpointNumber)
        {
            indicatorParticles.SetActive(true);
            CheckpointSetter.largestCheckpointNumber = checkpointNumberManual;
        }


        if (DeathScript.dead == true)
        {
            if (CheckpointSetter.largestCheckpointNumber == checkpointNumberManual)
            {
                Vector3 newPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
                player.transform.position = newPos;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            touchingCheckpoint = true;
        }
    }
}