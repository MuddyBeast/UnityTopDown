using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
    bool active;

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            active = !active;
        }
    }
}
