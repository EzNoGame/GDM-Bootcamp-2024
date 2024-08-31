using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCountDisplay : MonoBehaviour
{
    private void Update() {
        GetComponent<TMP_Text>().text = "Coins: " + CoinManager.Instance.CoinCount;
    }
}
