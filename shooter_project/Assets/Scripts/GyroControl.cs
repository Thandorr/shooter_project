using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour {

    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    public GameObject body;
    private Quaternion rot;

    


	// Use this for initialization
	private void Start () {
        gyroEnabled = EnableGyro();
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.gameObject.tag = "Kam";
        cameraContainer.transform.position = transform.position;
        cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
        transform.SetParent(cameraContainer.transform);
       // cameraContainer.transform.parent = body.transform;
        gyroEnabled = EnableGyro();
	}
	
	// Update is called once per frame
	

   
    private void Update()
    {
        if(gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot;
           
            


        }
    }
    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            //cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);
        
            return true;
        }
        return false;
    }
}
