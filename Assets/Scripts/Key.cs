using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.SendMessage("CollectKey");
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 50 * Time.fixedDeltaTime, 0);
    }
}
