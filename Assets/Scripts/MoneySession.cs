using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySession : MonoBehaviour
{
    //Serialized Variables
    [Header("Stats")]
    [SerializeField] float tickTime = 1f;
    [SerializeField] float valuePerClick = 1;

    //Variables
    float currentMoney = 0;
    float upgradeOneValue = 0;
    float autoOneValue = 0;
    float autoValue = 0;
    int autoOnePrice;
    float upgradeOnePrice;

    //Cashing
    MoneyUpgrade upgradeOne;
    AutoUpgrade autoOne;

    // Start is called before the first frame update
    void Start()
    {
        UpgradeCalc();
        AutoCalc();
        InvokeRepeating("AutoAdding", tickTime, tickTime);

    }

    // Update is called once per frame
    void Update()
    {
        AutoCalc();
    }
    //Money Button related
    public void AddMoney()    
    {

        UpgradeCalc();
        AdditionCalc();
        currentMoney = currentMoney + valuePerClick;
    }

    private void AdditionCalc()
    {
        valuePerClick = upgradeOneValue;
    }
     // Getting Upgrade Values
    private void UpgradeCalc()
    {
        upgradeOne = FindObjectOfType<MoneyUpgrade>();
        upgradeOneValue = upgradeOne.GetUpgradeOne();
    }

    public void PriceUpgradeOne()
    {
        upgradeOne = FindObjectOfType<MoneyUpgrade>();
        upgradeOnePrice = upgradeOne.GetPriceUpgradeOne();
        currentMoney = currentMoney - upgradeOnePrice;
    }
    //Auto Stuff
    private void AutoAdding()
    {
        currentMoney = currentMoney + autoValue;
    }

    private void AutoCalc()
    {
        AutoOneValueCalc();
        autoValue = autoOneValue;
    }

    private void AutoOneValueCalc()
    {
        autoOne = FindObjectOfType<AutoUpgrade>();
        autoOneValue = autoOne.GetAutoValue1();
    }
    public void PriceAutoOne()
    {
        autoOne = FindObjectOfType<AutoUpgrade>();
        autoOnePrice = autoOne.GetPriceAuto1();
        currentMoney = currentMoney - autoOnePrice;
    }



    // Giving Values to other Objects

    // Giving the Current Money Value
    public float GetMoney()
    {
        return currentMoney;
    }

    //Giving the current Value per Clock
    public float GetAValuePerClick()
    {
        return valuePerClick;
    }
}
