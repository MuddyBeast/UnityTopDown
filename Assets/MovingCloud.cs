using UnityEngine;
using System.Collections;

public class MovingCloud : MonoBehaviour
{
    public float speed = 0.02f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed);
        if (transform.position.y > 8)
            transform.position = new Vector2(transform.position.x, -8);

    }
}
