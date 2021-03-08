using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoUpgrade : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] float upgradeValue = 1;
    [SerializeField] int startPrice = 10;
    [SerializeField] int priceMultiplicator = 2;
    [Header("Debug")]
    [SerializeField] int upgradeCount = 0;
    [SerializeField] float currentValue = 0;
    [SerializeField] int currentPrice;
    
    float currentMoney;
    MoneySession moneyValue;


    public void AddValue()
    {
        CallMoneyValue();
        PriceCalc();
        if (currentMoney >= currentPrice)
        {
            moneyValue.PriceAutoOne(); //Paying the Price
            upgradeCount++;
            currentValue = upgradeValue * upgradeCount;
            PriceCalc();
        }
        else
        {
            Debug.Log("Not enough money");
        }
    }

    private void PriceCalc()
    {
        if (upgradeCount >= 1)
        {
            currentPrice = startPrice * priceMultiplicator * upgradeCount;
        }
        else
        {
            currentPrice = startPrice;
        }
    }
    //Getting Values from other Objects
    private void CallMoneyValue()
    {
        moneyValue = FindObjectOfType<MoneySession>();
        currentMoney = moneyValue.GetMoney();
    }
    //Handing Values to other Objects
    //Handing the vurrent Value per Tick
    public float GetAutoValue1()
    {
        return currentValue;
    }
    //Handing Current Price
    public int GetPriceAuto1()
    {
        return currentPrice;
    }
}
