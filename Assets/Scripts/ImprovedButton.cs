using UnityEngine;
using System.Collections;

public class ImprovedButton : MonoBehaviour
{
    public SpriteRenderer darkCloud;
    public bool active;
    public bool onAndOffButton;

    SpriteRenderer renderer;

    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.color = Color.red;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        //If using a button that you can turn on and off.
        if (onAndOffButton && Input.GetKeyDown(KeyCode.E))
        {
            active = !active;
            if (active)
            {
                renderer.color = Color.green;
                darkCloud.enabled = false;
            }
            else
            {
                renderer.color = Color.red;
                darkCloud.enabled = true;
            }
        }
            //If just an on switch
        else if (Input.GetKeyDown(KeyCode.E))
            if (!active)
            {
                active = true;
                darkCloud.enabled = false;
                renderer.color = Color.green;
            }
    }
}

