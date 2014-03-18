using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public Vector2 Speed = new Vector2(50, 50);
    private Vector2 _movement;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        _movement = new Vector2(inputX * Speed.x, inputY * Speed.y);
    }

    void FixedUpdate()
    {
        if (rigidbody2D != null)
            rigidbody2D.velocity = _movement;
    }
}