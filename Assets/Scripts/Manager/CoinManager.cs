using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int CoinCount {get; private set;}
    public static CoinManager Instance { get; private set; }

    private void OnEnable() {
        if(Instance!=null && Instance != this) {
            Destroy(this);
        } else {
            Instance = this;
        }    
    }
    private void OnDisable() {
        if(Instance!=null&& Instance == this) 
        {
            Instance = null;
        }
    }

    private void Start() {
        CoinCount = 0;
    }

    public void AddCoin() {
        CoinCount++;
    } 
}
