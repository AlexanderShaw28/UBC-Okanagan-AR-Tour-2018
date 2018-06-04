using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video; 

public class streamVideo : MonoBehaviour {
    public RawImage image;

    private VideoPlayer videoPlayer;
    private VideoSource videoSource;
    private AudioSource audioSource; 

	// Use this for initialization
	void Start () {
        Application.runInBackground = true;
        StartCoroutine(playVideo()); 
		
	}

    IEnumerator playVideo()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        audioSource = gameObject.AddComponent<AudioSource>();

        videoPlayer.playOnAwake = false;
        audioSource.playOnAwake = false;
        audioSource.Pause();

        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "http://06-lvl3-pdl.vimeocdn.com/01/1988/4/109943349/301408241.mp4?expires=1511927713&token=0a95038fe0ae9413ccea9";

        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.SetTargetAudioSource(0, audioSource);

        videoPlayer.Prepare();

        WaitForSeconds waitTime = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            Debug.Log("Preparing Video");

            yield return waitTime;

            break;
        }

        Debug.Log("Done Preparing Video");

        image.texture = videoPlayer.texture;

        videoPlayer.Play();

        audioSource.Play();

        Debug.Log("Playing Video");
        while (videoPlayer.isPlaying)
        {
            Debug.LogWarning("Video Time: " + Mathf.FloorToInt((float)videoPlayer.time));
            yield return null;
        }

        Debug.Log("Done Playing Video");
    }




 }

