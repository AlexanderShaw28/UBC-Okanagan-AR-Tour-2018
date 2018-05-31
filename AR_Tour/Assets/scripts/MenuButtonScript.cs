using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class MenuButtonScript : MonoBehaviour {

	public GameObject Menu;
    public GameObject CloseButton;

	public Animator AniMenu;
	
	// Use this for initialization


	public void ClickOnMe(){
		Menu.SetActive (true);
		


		AniMenu = Menu.GetComponent<Animator> ();
		

		AniMenu.Play ("slide_out");
		

        CloseButton.SetActive(true);

	}

	public void CloseMenu(){

		/* Animation animation1 = Menu.GetComponent<Animation> ();
		Animation animation2 = Quad.GetComponent<Animation> ();

		animation1["slide_out"].speed = -1;
		animation2["Quadslide"].speed = -1;

		animation1["slide_out"].time = animation1["slide_out"].length;
		animation2["Quadslide"].time = animation2["Quadslide"].length;


		animation1.Play ("slide_out");
		animation2.Play ("Quadslide");

		Menu.SetActive (false);
		Quad.SetActive (false);

		animation1["slide_out"].speed = 1;
		animation2["Quadslide"].speed = 1;

		animation1["slide_out"].time = 0;
		animation2["Quadslide"].time = 0; */


		AniMenu = Menu.GetComponent<Animator> ();
		

		AniMenu.Play ("ReverseSlideOut");
		

        CloseButton.SetActive(false);
	
        
		//Menu.SetActive (false);
		//Quad.SetActive (false);




	}


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
