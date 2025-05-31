using System;
using TMPro;
using UnityEngine;

public class TurretDetailedView : MonoBehaviour
{
    [SerializeField] TurretStatsSO turretStatsSO;
    [SerializeField] TextMeshProUGUI damageText;
    [SerializeField] TextMeshProUGUI costText;

    [SerializeField] TextMeshProUGUI upgradeText;
    [SerializeField] TextMeshProUGUI fireRateText;

    public void UpdateView(TurretStatsSO statsSO)
    {
        damageText.text = statsSO.damage.ToString();
        costText.text = statsSO.cost.ToString();
        upgradeText.text = statsSO.upgrade.ToString();
        fireRateText.text = statsSO.fireRate.ToString();
    }

   
}
