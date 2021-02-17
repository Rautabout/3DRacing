using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarStableCamera : MonoBehaviour
{
    public GameObject Vehicle;
    public float VehicleX;
    public float VehicleY;
    public float VehicleZ;
    void Update()
    {
        VehicleX = Vehicle.transform.eulerAngles.x;
        VehicleY = Vehicle.transform.eulerAngles.y;
        VehicleZ = Vehicle.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(VehicleX - VehicleX, VehicleY,VehicleZ-VehicleZ);
    }
}
