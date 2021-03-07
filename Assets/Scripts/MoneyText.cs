using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyText : MonoBehaviour
{
    MoneySession moneySession;
    TextMeshProUGUI moneyText;

    // Start is called before the first frame update
    void Start()
    {
        moneyText = GetComponent<TextMeshProUGUI>();
        moneySession = FindObjectOfType<MoneySession>();
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = moneySession.GetMoney().ToString();
    }

}
