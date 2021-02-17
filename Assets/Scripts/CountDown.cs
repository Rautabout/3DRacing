using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;


public class CountDown : MonoBehaviour
{
    public GameObject Countdown;
    public GameObject LapTimer;
    public GameObject CarControls;
    public GameObject Enemy1;
    public GameObject Enemy2;


    void Start()
    {
        StartCoroutine(CountStart());
    }
    IEnumerator CountStart()
    {
        LapTimer.SetActive(false);
        yield return new WaitForSeconds(.5f);
        Countdown.GetComponent<Text>().text = "3";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "2";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "1";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        LapTimer.SetActive(true);
        CarControls.GetComponent<CarController>().enabled = true;
        Enemy1.GetComponent<CarAIControl>().enabled = true;
        Enemy2.GetComponent<CarAIControl>().enabled = true;

    }
}


