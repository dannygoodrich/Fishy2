using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        gameManager.CompleteLevel();
    }
}
