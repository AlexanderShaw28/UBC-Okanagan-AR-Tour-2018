using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTime : MonoBehaviour {

    public GameObject Loader;
    public float timer;

	// Use this for initialization
	void Start () {

        Destroy(Loader, timer);

	}

}
