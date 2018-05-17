using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class cameraView : MonoBehaviour
{


    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rot;


    private bool camAvailable;
    private WebCamTexture backCam;
    private Texture defaultBackground;

    public RawImage background;
    public AspectRatioFitter fit;

    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
           

            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true; 
        }

        return false; 
    }


    private void Start()
    {
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);

        gyroEnabled = EnableGyro(); 


        defaultBackground = background.texture;
        WebCamDevice[] devices = WebCamTexture.devices; 

        if (devices.Length == 0)
        {
            Debug.Log("No camera detected");
            camAvailable = false;
            return; 
        }

        for (int i = 0; i <devices.Length; i++)
        {
            if (!devices[i].isFrontFacing)
            {
                backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);

            }
        }

        if (backCam == null)
        {
            Debug.Log("Can't find Back Cam");
            return; 
        }

        backCam.Play();
        background.texture = backCam;

        camAvailable = true; 
    }

    private void Update()
    {

        
        if (gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot; 
        }

        if (!camAvailable)
            return;
        float ratio = (float)backCam.width / (float)backCam.height;
        fit.aspectRatio = ratio;

        float scaleY = backCam.videoVerticallyMirrored ? -1f : 1f;
        background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);

        int orient = -backCam.videoRotationAngle;
        background.rectTransform.localEulerAngles = new Vector3(0, 0, orient);
    }
}

