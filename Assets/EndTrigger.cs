using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    private object collisionInfo;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("player"))
        gameManager.CompleteLevel();
    }
}
