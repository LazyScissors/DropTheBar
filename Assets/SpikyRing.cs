﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikyRing : MonoBehaviour {

    public GameObject attachedBar;
    public GrabbingBar currentBar;
    bool aimUp = false;

    const float targetMinOffset = .1f;
    public float speed = .1f;

    // Use this for initialization
    void Start ()
    {
        currentBar = attachedBar.GetComponent<GrabbingBar>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector3.Magnitude(transform.position - currentBar.up) < targetMinOffset)
            aimUp = false;
        else if (Vector3.Magnitude(transform.position - currentBar.down) < targetMinOffset)
            aimUp = true;


            if (aimUp)
                transform.position = Vector3.MoveTowards(transform.position, currentBar.up, speed);
            else
                transform.position = Vector3.MoveTowards(transform.position, currentBar.down, speed);
    }

}
