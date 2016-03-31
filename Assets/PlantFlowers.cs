using UnityEngine;
using System.Collections;

public class PlantFlowers : MonoBehaviour
{
    public Sprite flower;
    public bool active;
    public SpriteRenderer darkCloud;

    SpriteRenderer renderer;

    void Start()
    {
        renderer = GetComponentInChildren<SpriteRenderer>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E) && !active && darkCloud.enabled == false)
            {
                active = true;
                renderer.sprite = flower;
            }
    }
}
