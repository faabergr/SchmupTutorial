using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
    private WeaponScript _weapon;

    void Awake()
    {
        _weapon = GetComponent<WeaponScript>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (_weapon != null && _weapon.CanAttack)
        {
            _weapon.Attack(true);
        }
	}
}
