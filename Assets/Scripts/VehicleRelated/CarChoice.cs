using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject BlackBody;
    public GameObject GreenBody;
    public GameObject RedBody;

    public int CarImport;


    void Start()
    {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1)
        {
            BlackBody.SetActive(true);
        }
        if (CarImport == 2)
        {
            GreenBody.SetActive(true);
        }
        if (CarImport == 3)
        {
            RedBody.SetActive(true);
        }
    }


}
