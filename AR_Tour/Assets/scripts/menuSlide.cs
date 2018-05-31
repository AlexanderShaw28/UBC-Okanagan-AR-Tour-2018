using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuSlide : MonoBehaviour {

    //refrence for the pause menu panel in the hierarchy
    public GameObject MenuPanel;
    //animator reference
    private Animator anim;
    //variable for checking if the game is paused 
    bool MenuIn = false;

    public bool MenuIn1
    {
        get
        {
            return MenuIn;
        }

        set
        {
            MenuIn = value;
        }
    }


    // Use this for initialization
    void Start () {
        //menu is out of sight to begin
        Time.timeScale = 1;
        //get the animator component
        anim = MenuPanel.GetComponent<Animator>();
        //disable it on start to stop it from playing the default animation
        anim.enabled = false;
    }

    //function to pause the game
    public void SlideIn()
    {
        //enable the animator component
        anim.enabled = true;
        //play the Slidein animation
        anim.Play("MenuPanelSlideIn");
        //set the isPaused flag to true to indicate that the game is paused
        MenuIn1 = true;
        //freeze the timescale
        Time.timeScale = 0;
    }
    //function to unpause the game
    public void SlideOut()
    {
        //set the isPaused flag to false to indicate that the game is not paused
        MenuIn1 = false;
        //play the SlideOut animation
        anim.Play("MenuPanelSlideOut");
        //set back the time scale to normal time scale
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update () {
        
    }
}
