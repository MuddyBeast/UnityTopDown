﻿using UnityEngine;
using System.Collections;

public class VisionProjectile : MonoBehaviour {

	public float speed = 0.5f;
	public float lifeSpann = 0.8f; 
	float currentTime = 0.0f;

    void Start()
    {
        VisionPreferences.visionProjectile = true;
    }
	// Update is called once per frame
	void Update () 
	{
		currentTime += Time.deltaTime;
		transform.Translate (Vector2.up * speed * Time.deltaTime);
        VisionPreferences.projectileTransform = transform;

		//Attach modified visionscript HERE PLEASE.  
		if (currentTime > lifeSpann) 
		{
            VisionPreferences.visionProjectile = false;
			Destroy (gameObject);
		}
	}
}