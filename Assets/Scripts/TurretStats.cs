using System;
using UnityEngine;
[CreateAssetMenu(fileName = "NewTurretStats", menuName = "ScriptableObjects/TurretStats")]

[Serializable]
public class TurretStatsSO:ScriptableObject
{
    public int cost;
    public int damage;

    public float fireRate;

    public int upgrade;
}
