using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollisionDetection : MonoBehaviour
{
    GameObject END;
    void OnCollisionEnter2D(UnityEngine.Collision2D collisionInfo)
    {
        Debug.Log(transform.localScale.x);
        END = GameObject.FindGameObjectWithTag("EndLevel");
        if (transform.localScale.y > collisionInfo.gameObject.transform.localScale.y && collisionInfo.collider.CompareTag("enemy"))
        {

            if (transform.localScale.x < 0)
            {
                transform.localScale += new Vector3(-.2f, .2f, 1);
                Destroy(collisionInfo.gameObject);
                Debug.Log(collisionInfo.collider);
                Debug.Log(collisionInfo);

            }
            else if (transform.localScale.x > 0)
            {
                transform.localScale += new Vector3(.2f, .2f, 1);
                Destroy(collisionInfo.gameObject);
            }
            //transform.localScale += new Vector3(Math.Abs(1.01f), 1.01f);
            //transform.localScale += new Vector3(1.01f, 1.01f);
            Debug.Log("hit something!");

        }
        //if (collisionInfo.collider.tag == "EndLevel")
        //{
        //    FindObjectOfType<GameManager>().CompleteLevel();
        //    return;
        //}
        if (transform.localScale.y < collisionInfo.gameObject.transform.localScale.y)
        {
            //FindObjectOfType<GameManager>().CompleteLevel();
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
