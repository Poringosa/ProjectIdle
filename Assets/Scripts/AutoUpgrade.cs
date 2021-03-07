using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoUpgrade : MonoBehaviour
{
    [SerializeField] float upgradeValue = 1;
    [SerializeField] float upgradeCount = 0;
    [SerializeField] float currentValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddValue()
    {
        upgradeCount++;
        currentValue = upgradeValue * upgradeCount;
    }

    public float GetAutoValue1()
    {
        return currentValue;
    }
}
