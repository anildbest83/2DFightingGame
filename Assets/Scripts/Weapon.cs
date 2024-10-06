using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Weapon : ScriptableObject
{
    public new string name;
    public string description;
    public float damage;
    public float BulletSpeed;
    public float range;
    public float fireRate;
}
