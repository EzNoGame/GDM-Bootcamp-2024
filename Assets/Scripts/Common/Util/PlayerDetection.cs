using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PlayerDetection : MonoBehaviour
{
    protected bool _isPlayerDetected = false;

    public virtual void OnPlayerEneter()
    {
    }

    public virtual void OnPlayerExit()
    {
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Player")) {
            _isPlayerDetected = true;
            OnPlayerEneter();
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            _isPlayerDetected = false;
            OnPlayerExit();
        }
    }
}
