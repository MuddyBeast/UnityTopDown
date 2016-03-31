using UnityEngine;
using System.Collections;

public class Popup : MonoBehaviour
{
    float distance;
    float distanceAlpha;
    float distanceToProjectile;
    SpriteRenderer sprite;
    //public float distanceForPlatformToAppear = 5f;

    // Use this for initialization
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
        distance = Vector2.Distance(transform.position, VisionPreferences.playerTransform.position);
        distanceAlpha = VisionPreferences.distanceForPlatformToAppear/5 - distance/5;
        sprite.color = new Color(1f, 1f, 1f, distanceAlpha);
        //if (distance < VisionPreferences.distanceForPlatformToAppear)
        //    ShowPlatform();
        //else
        //    HidePlatform();
    }


    void FixedUpdate()
    {


    }

    void ShowPlatform()
    {
        sprite.enabled = true;
    }

    void HidePlatform()
    {
        sprite.enabled = false;
    }
}