using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySession : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] float autoTime = 1f;
    [Header("Debug")]
    [SerializeField] float currentMoney = 0;
    [SerializeField] float valuePerClick = 1;
    [SerializeField] float upgradeOneValue = 0;
    [SerializeField] float autoOneValue = 0;
    [SerializeField] float autoValue = 0;
    MoneyUpgrade upgradeOne;
    AutoUpgrade autoOne;

    // Start is called before the first frame update
    void Start()
    {
        UpgradeCalc();
        AutoCalc();
        InvokeRepeating("AutoAdding", 1F, 1F);

    }

    // Update is called once per frame
    void Update()
    {
        AutoCalc();
    }

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
