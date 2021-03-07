using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyUpgrade : MonoBehaviour
{   
    [Header("Base Stats")]
    [SerializeField] long upgradeValue = 2;
    [SerializeField] int multiplicatorTen = 3;

    [Header("Debug")]
    [SerializeField] float currentUpgradeValue = 0;
    [SerializeField] float currentMultiplicator = 1;
    [SerializeField] long upgradeCount = 0;

    private void Start()
    {
        currentUpgradeValue = 1;
    }

    private void Update()
    {
        GetUpgradeOne();
    }
    public void UpgradeOneClick()
    {
        upgradeCount++;
        MultiplicatorCalc();
        currentUpgradeValue = currentUpgradeValue + upgradeValue * currentMultiplicator;
    }

    private void MultiplicatorCalc()
    {
        currentMultiplicator =  Mathf.Floor((upgradeCount / 10) * multiplicatorTen); // Multiplicator each 10 Upgrades
        if(upgradeCount <= 10)
        {
            currentMultiplicator = 1;
        }

    }

    public float GetUpgradeOne()
    {
        return currentUpgradeValue;
    }


}
