using UnityEngine;
using System.Collections;

public class VisionPreferences : MonoBehaviour {
    static public Transform playerTransform;
    static public float distanceForPlatformToAppear = 12f;
    static public bool visionProjectile = false;
    static public Transform projectileTransform;

	// Use this for initialization
	void Start () 
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}

    void Update()
    {
        if (visionProjectile == false && projectileTransform != null)
            projectileTransform = null;
    }
	
}
