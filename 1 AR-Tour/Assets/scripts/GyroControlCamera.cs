using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GyroControlCamera : MonoBehaviour {

    public GameObject Camera;

    void Start()
    {
        Input.gyro.enabled = true;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
      
    }

    void Update()
    {
        Camera.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, 0);
    }

    public void close360()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        SceneManager.LoadScene("simpleAr");
        
    }


}
