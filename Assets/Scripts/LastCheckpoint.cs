using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCheckpoint : MonoBehaviour
{
    public GameObject CheckpointTrig;
    public GameObject Checkpoint1Trig;

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CheckpointTrig.SetActive(false);
            Checkpoint1Trig.SetActive(true);
            yield return new WaitForSeconds(1);

        }
    }
}
