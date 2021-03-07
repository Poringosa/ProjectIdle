using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdditionText : MonoBehaviour
{
    MoneySession moneySession;
    TextMeshProUGUI additionText;

    // Start is called before the first frame update
    void Start()
    {
        additionText = GetComponent<TextMeshProUGUI>();
        moneySession = FindObjectOfType<MoneySession>();
    }

    // Update is called once per frame
    void Update()
    {
        additionText.text = moneySession.GetAValuePerClick().ToString();
    }

}
