using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject Checkpoint;

    public GameObject MinuteDispl;
    public GameObject SecondDispl;
    public GameObject MiliDispl;

    public GameObject LapTimeBox;

    public GameObject LapCount;
    public int LapsDone;

    public float RawTime;

    public GameObject RaceFinish;

    private void Update()
    {
        if (LapsDone == 2)
        {
            RaceFinish.SetActive(true);
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LapsDone += 1;
            RawTime = PlayerPrefs.GetFloat("RawTime");
            if (LapTimeManager.RawTime <= RawTime)
            {
                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDispl.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                }
                else
                {
                    SecondDispl.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
                }
                if (LapTimeManager.MinuteCount <= 9)
                {
                    MinuteDispl.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ":";
                }
                else
                {
                    MinuteDispl.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ":";
                }
                MiliDispl.GetComponent<Text>().text = "" + LapTimeManager.MiliCount;
            }


            PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
            PlayerPrefs.SetFloat("MiliSave", LapTimeManager.MiliCount);

            PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);


            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MiliCount = 0;
            LapTimeManager.RawTime = 0;
            LapCount.GetComponent<Text>().text = "" + LapsDone;
            Checkpoint.SetActive(true);
            LapCompleteTrig.SetActive(false);
            yield return new WaitForSeconds(1);

        }
    }

    /*void OnTriggerEnter()
    {
        LapsDone += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManager.RawTime <= RawTime)
        {
            if (LapTimeManager.SecondCount <= 9)
            {
                SecondDispl.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
            }
            else
            {
                SecondDispl.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
            }
            if (LapTimeManager.MinuteCount <= 9)
            {
                MinuteDispl.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ":";
            }
            else
            {
                MinuteDispl.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ":";
            }
            MiliDispl.GetComponent<Text>().text = "" + LapTimeManager.MiliCount;
        }


        PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
        PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
        PlayerPrefs.SetFloat("MiliSave", LapTimeManager.MiliCount);

        PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);


        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MiliCount = 0;
        LapTimeManager.RawTime = 0;
        LapCount.GetComponent<Text>().text = "" + LapsDone;
        Checkpoint.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
    */

}
