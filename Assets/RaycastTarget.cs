using System;
using UnityEngine;

public class RaycastTarget : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;

    [SerializeField] GameObject turretPanel;
    [SerializeField] TurretStatsSO turretStatsSO;

    private int cost;

    private float fireRate;

    private int damage;

    private int upgrade;
   

    void Awake()
    {
       
      sr = GetComponentInChildren<SpriteRenderer>();

    }

    void Start()
    {
        turretStatsSO= new TurretStatsSO();
        cost = turretStatsSO.cost;
        fireRate = turretStatsSO.fireRate;
        damage = turretStatsSO.damage;
        upgrade = turretStatsSO.upgrade;
        
    }


    public void OnMouseEnter()
    {
        sr.color = Color.green;
        turretPanel.SetActive(true);
    }

    public void OnMouseExit()
    {
        sr.color = Color.white;
        turretPanel.SetActive(false);
    }


}
