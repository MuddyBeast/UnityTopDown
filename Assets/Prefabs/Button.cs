using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
    public bool active;
    public Color activeColor, inactiveColor;
    public bool multipleSwitches;
    bool canChange;

    SpriteRenderer buttonColor;

    void Start()
    {
        buttonColor = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
    }

    void OnTriggerStay2D(Collider2D other)
    {
    
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (multipleSwitches)
            {
                active = !active;

                if (active)
                    buttonColor.color = activeColor;

                else
                    buttonColor.color = inactiveColor;
            }

            else
            {
                if (!active)
                    active = !active;

            }
        }
    }
}
