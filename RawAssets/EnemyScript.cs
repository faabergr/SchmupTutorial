using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
    private WeaponScript[] _weapons;

    void Awake()
    {
        // Retrieve the weapon only once
        _weapons = GetComponentsInChildren<WeaponScript>();

        Debug.Log("Awake!");
    }

    void Update()
    {
        Debug.Log("Got here!!");

        foreach (WeaponScript weapon in _weapons)
        {
            // Auto-fire
            if (weapon != null && weapon.CanAttack)
            {
                weapon.Attack(true);
            }
        }
    }
}
