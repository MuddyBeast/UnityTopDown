using UnityEngine;
using System.Collections;

public class DistanceToPlayerTopDown : MonoBehaviour
{
    float distance;
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
        if (VisionPreferences.visionProjectile)
            if (VisionPreferences.projectileTransform != null)
                distanceToProjectile = Vector2.Distance(transform.position, VisionPreferences.projectileTransform.position);
        if (VisionPreferences.visionProjectile == false)
            distanceToProjectile = Mathf.Infinity;
    }


    void FixedUpdate()
    {
        if (distance < VisionPreferences.distanceForPlatformToAppear)
            ShowPlatform();
        else if (VisionPreferences.visionProjectile)
        {
            if (VisionPreferences.distanceForPlatformToAppear - 2 > distanceToProjectile)
                ShowPlatform();
            else
                HidePlatform();
        }
        else
            HidePlatform();

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