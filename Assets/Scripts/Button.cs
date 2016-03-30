using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
    public bool active;
    bool canChange;

    SpriteRenderer renderer;

    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (canChange && Input.GetKeyDown(KeyCode.E))
        {
            active = !active;
        }

        if (active)
            renderer.color = Color.green;

        else
            renderer.color = Color.red;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        canChange = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        canChange = false;
    }
}
