using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour
{
    /// <summary>
    /// Damage inflicted
    /// </summary>
    public int Damage = 1;

    /// <summary>
    /// Was this shot by the player or an enemy?
    /// </summary>
    public bool IsEnemyShot = false;

    // Use this for initialization
    void Start()
    {
        Destroy(this, 20); // destroy after 20 seconds
    }

    // Update is called once per frame
    void Update()
    {

    }
}
