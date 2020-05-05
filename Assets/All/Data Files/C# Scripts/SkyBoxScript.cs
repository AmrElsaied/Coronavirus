using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxScript : MonoBehaviour {

    public Material skyOne;


    // Use this for initialization
    void Start () {

        RenderSettings.skybox = skyOne;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
