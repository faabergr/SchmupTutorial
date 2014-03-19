using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    /// <summary>
    /// Total health
    /// </summary>
    public int HitPoints = 1;

    /// <summary>
    /// If this script is attached to an enemy
    /// </summary>
    public bool IsEnemy = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// Inflicts damage and determines if the game object should be destroyed
    /// </summary>
    /// <param name="damageCount"></param>
    public void Damage(int damageCount)
    {
        HitPoints -= damageCount;

        if (HitPoints <= 0)
        {
            // Dead!
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Is this a shot?
        ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
        if (shot != null)
        {
            // Don't shoot yourself
            if (shot.IsEnemyShot != IsEnemy)
            {
                Damage(shot.Damage);

                // Destroy shot gameobject, not shot script
                Destroy(shot.gameObject);
            }
        }
    }
}
