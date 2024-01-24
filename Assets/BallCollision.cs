using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public string cornerTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(cornerTag))
        {
            Destroy(gameObject); 
        }
    }
}
