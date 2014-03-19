using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour
{

    /// <summary>
    /// The prefab of a shot
    /// </summary>
    public Transform ShotPrefab;

    /// <summary>
    /// Rate of fire, used for cooldown
    /// </summary>
    public float ShootingRate = 0.25f;

    private float _currentCooldown;

    // Use this for initialization
    void Start()
    {
        _currentCooldown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentCooldown > 0)
        {
            _currentCooldown -= Time.deltaTime;
        }
    }

    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            _currentCooldown = ShootingRate;

            var shotTransform = Instantiate(ShotPrefab) as Transform;
            shotTransform.position = transform.position;

            ShotScript shot = shotTransform.GetComponent<ShotScript>() as ShotScript;
            if (shot != null)
            {
                shot.IsEnemyShot = isEnemy;
            }

            MoveScript move = shotTransform.GetComponent<MoveScript>() as MoveScript;
            if (move != null)
            {
                // move right in 2D space
                move.Direction = this.transform.right;
            }
        }
    }

    public bool CanAttack
    {
        get { return _currentCooldown <= 0f; }
    }
}
