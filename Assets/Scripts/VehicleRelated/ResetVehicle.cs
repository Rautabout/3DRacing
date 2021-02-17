using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetVehicle : MonoBehaviour
{
    public GameObject Checkpoint1;
    public GameObject Checkpoint2;
    public GameObject Checkpoint3;
    public GameObject Checkpoint4;

    public GameObject Car;

    void Update()
    {
        if (Input.GetButtonDown("Reset"))
        {
            if (Checkpoint1.activeSelf==false)
            {
                Car.transform.position = Checkpoint1.transform.position;
                Car.transform.rotation = Checkpoint1.transform.rotation;
            }if (Checkpoint2.activeSelf==false)
            {
                Car.transform.position = Checkpoint2.transform.position;
                Car.transform.rotation = Checkpoint2.transform.rotation;
            }if (Checkpoint3.activeSelf==false)
            {
                Car.transform.position = Checkpoint3.transform.position;
                Car.transform.rotation = Checkpoint3.transform.rotation;
            }if (Checkpoint4.activeSelf==false)
            {
                Car.transform.position = Checkpoint4.transform.position;
                Car.transform.rotation = Checkpoint4.transform.rotation;
            }
            
        }
    }

    /*IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(.01f);
        if (CamMode == 0)
        {
            
        }
        if (CamMode == 1)
        {
    
        }
        if (CamMode == 2)
        {
            
        }
        if (CamMode == 2)
        {
            
        }
    }*/
}
