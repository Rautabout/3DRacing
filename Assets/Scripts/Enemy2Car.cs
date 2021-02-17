using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Car : MonoBehaviour
{
    public GameObject TheTracker;
    public GameObject Mark1;
    public GameObject Mark2;
    public GameObject Mark3;
    public GameObject Mark4;
    public GameObject Mark5;
    public GameObject Mark6;
    public GameObject Mark7;
    public GameObject Mark8;
    public GameObject Mark9;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;
    public GameObject Mark19;
    public GameObject Mark20;
    public GameObject Mark21;
    public GameObject Mark22;
    public GameObject Mark23;
    public GameObject Mark24;
    public GameObject Mark25;
    public GameObject Mark26;
    public GameObject Mark27;
    public GameObject Mark28;

    public int MarkTracker;
    void Update()
    {
        if (MarkTracker == 0)
        {
            TheTracker.transform.position = Mark1.transform.position;
        }
        if (MarkTracker == 1)
        {
            TheTracker.transform.position = Mark2.transform.position;
        }
        if (MarkTracker == 2)
        {
            TheTracker.transform.position = Mark3.transform.position;
        }
        if (MarkTracker == 3)
        {
            TheTracker.transform.position = Mark4.transform.position;
        }
        if (MarkTracker == 4)
        {
            TheTracker.transform.position = Mark5.transform.position;
        }
        if (MarkTracker == 5)
        {
            TheTracker.transform.position = Mark6.transform.position;
        }
        if (MarkTracker == 6)
        {
            TheTracker.transform.position = Mark7.transform.position;
        }
        if (MarkTracker == 7)
        {
            TheTracker.transform.position = Mark8.transform.position;
        }
        if (MarkTracker == 8)
        {
            TheTracker.transform.position = Mark9.transform.position;
        }
        if (MarkTracker == 9)
        {
            TheTracker.transform.position = Mark10.transform.position;
        }
        if (MarkTracker == 10)
        {
            TheTracker.transform.position = Mark11.transform.position;
        }
        if (MarkTracker == 11)
        {
            TheTracker.transform.position = Mark12.transform.position;
        }
        if (MarkTracker == 12)
        {
            TheTracker.transform.position = Mark13.transform.position;
        }
        if (MarkTracker == 13)
        {
            TheTracker.transform.position = Mark14.transform.position;
        }
        if (MarkTracker == 14)
        {
            TheTracker.transform.position = Mark15.transform.position;
        }
        if (MarkTracker == 15)
        {
            TheTracker.transform.position = Mark16.transform.position;
        }
        if (MarkTracker == 16)
        {
            TheTracker.transform.position = Mark17.transform.position;
        }
        if (MarkTracker == 17)
        {
            TheTracker.transform.position = Mark18.transform.position;
        }
        if (MarkTracker == 18)
        {
            TheTracker.transform.position = Mark19.transform.position;
        }
        if (MarkTracker == 19)
        {
            TheTracker.transform.position = Mark20.transform.position;
        }
        if (MarkTracker == 20)
        {
            TheTracker.transform.position = Mark21.transform.position;
        }
        if (MarkTracker == 21)
        {
            TheTracker.transform.position = Mark22.transform.position;
        }
        if (MarkTracker == 22)
        {
            TheTracker.transform.position = Mark23.transform.position;
        }
        if (MarkTracker == 23)
        {
            TheTracker.transform.position = Mark24.transform.position;
        }
        if (MarkTracker == 24)
        {
            TheTracker.transform.position = Mark25.transform.position;
        }
        if (MarkTracker == 25)
        {
            TheTracker.transform.position = Mark26.transform.position;
        }
        if (MarkTracker == 26)
        {
            TheTracker.transform.position = Mark27.transform.position;
        }
        if (MarkTracker == 27)
        {
            TheTracker.transform.position = Mark28.transform.position;
        }

    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy2")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 28)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
