using UnityEngine;

public class MoveScript : MonoBehaviour
{
    /// <summary>
    /// Object speed
    /// </summary>
    public Vector2 Speed = new Vector2(10, 10);

    /// <summary>
    /// Moving direction
    /// </summary>
    public Vector2 Direction = new Vector2(-1, 0);

    private Vector2 _movement;

    // Update is called once per frame
    void Update()
    {
        _movement = new Vector2(Speed.x * Direction.x, Speed.y * Direction.y);
    }

    // Called every fixed framerate frame, should be used when dealing with rigid body
    void FixedUpdate()
    {
        // Apply movement to the rigidbody
        rigidbody2D.velocity = _movement;
    }
}
