using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlVideos: MonoBehaviour {

    public GameObject CameraForVideo;
    public GameObject MainCamera;
    public GameObject VideoPlayerGroup;

    public GameObject DeptMenu;

    public GameObject CloseButton;

    public static string YoutubeVideoCode;
    public string code = YoutubeVideoCode;
  
    void Start()
    {
        MainCamera.SetActive(true);
        CameraForVideo.SetActive(false);
        VideoPlayerGroup.SetActive(false);
        CloseButton.SetActive(false);
    }
	
    public void Load2DVideo(string videocode)
    {

        YoutubeVideoCode = videocode;
        MainCamera.SetActive(false);
        CloseButton.SetActive(true);
       CameraForVideo.SetActive(true);
        VideoPlayerGroup.SetActive(true);
        DeptMenu.SetActive(false);

    }


    public void Load2DVideoSCENE(string videocode)
    {

        SceneManager.LoadScene("Play Video");
        YoutubeVideoCode = videocode;

    }

    public void Load360Video(string videocode)
    {
        SceneManager.LoadScene("360VideoPlayerBark");
        YoutubeVideoCode = videocode;
    }

    public void Close2DVideo()
    {
        MainCamera.SetActive(true);
        DeptMenu.SetActive(true);
        CameraForVideo.SetActive(false);
        VideoPlayerGroup.SetActive(false);
        CloseButton.SetActive(false);
    }
}
