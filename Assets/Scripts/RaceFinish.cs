using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject MyVehicle;
    public GameObject FinishMenu;
    public GameObject ViewModes;
    public GameObject FinishCamera;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MiliDisplay;


    private void OnTriggerEnter()
    {
        MyVehicle.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        MyVehicle.GetComponent<CarController>().enabled = false;
        MyVehicle.GetComponent<CarUserControl>().enabled = false;
        MyVehicle.SetActive(true);
        ViewModes.SetActive(false);


        FinishCamera.SetActive(true);
        FinishMenu.SetActive(true);
    }
}
