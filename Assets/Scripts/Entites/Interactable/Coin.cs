using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : PlayerDetection
{

    public float speed = 10f;

    private void FixedUpdate()
    {
        Transform tr = GetComponent<Transform>();
        tr.Rotate(Time.fixedDeltaTime * speed, 0f, 0f);
    }

    public override void OnPlayerEneter()
    {
        Debug.Log("Coin Collected");
        CoinCollectedCallback();
        gameObject.SetActive(false);
    }

    private void CoinCollectedCallback()
    {
        if (CoinManager.Instance == null)
        {
            Debug.LogError("there should be a coin manager, got none intstead");
            return;
        }

        CoinManager.Instance.AddCoin();
    }
}
