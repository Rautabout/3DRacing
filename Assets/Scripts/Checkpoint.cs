using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject Checkpoint1Trig;
    public GameObject CheckpointTrig;


    //void OnTriggerEnter(Collider collider)
    //{
    //    if (collider.GameObject.tag == "Player")
    //    {
    //        CheckpointTrig.SetActive(true);
    //        Checkpoint1Trig.SetActive(false);
    //     }

    // }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CheckpointTrig.SetActive(true);
            Checkpoint1Trig.SetActive(false);
            yield return new WaitForSeconds(1);

        }
    }
}
