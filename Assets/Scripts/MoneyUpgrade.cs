using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyUpgrade : MonoBehaviour
{   
    [Header("Base Stats")]
    [SerializeField] long upgradeValue = 2;
    [SerializeField] int multiplicatorTen = 3;
    [SerializeField] int startPrice = 10;
    [SerializeField] int priceMultiplicator = 5;

    [Header("Debug")]
    [SerializeField] float currentUpgradeValue = 0;
    [SerializeField] float currentMultiplicator = 1;
    [SerializeField] long upgradeOneCount = 0;
    [SerializeField] float currentPrice;

    float currentMoney;
    MoneySession moneyValue;

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
        PriceCalc();
        CallMoneyValue();
        if (currentMoney >= currentPrice)
        {
            moneyValue.PriceUpgradeOne(); //Paying the Price
            upgradeOneCount++;
            MultiplicatorCalc();
            currentUpgradeValue = currentUpgradeValue + upgradeValue * currentMultiplicator;
            PriceCalc();
        }
        else
        {
            Debug.Log("Not enough money!");
        }
    }

    private void PriceCalc()
    {
        if (upgradeOneCount >= 1)
        {
            currentPrice = startPrice * priceMultiplicator * upgradeOneCount;
        }
        else
        {
            currentPrice = startPrice;
        }
    }

    private void MultiplicatorCalc()
    {
        currentMultiplicator =  Mathf.Floor((upgradeOneCount / 10) * multiplicatorTen); // Multiplicator each 10 Upgrades
        if(upgradeOneCount <= 10)
        {
            currentMultiplicator = 1;
        }

    }

    private void CallMoneyValue()
    {
        moneyValue = FindObjectOfType<MoneySession>();
        currentMoney = moneyValue.GetMoney();
    }

    //Handing Values to other Objects
    public float GetUpgradeOne()
    {
        return currentUpgradeValue;
    }
     public float GetPriceUpgradeOne()
    {
        return currentPrice;
    }

}
