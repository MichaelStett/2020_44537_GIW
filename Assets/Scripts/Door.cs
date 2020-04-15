using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (CollectKeys.key == true)
            {
                var source = GetComponent<AudioSource>();
                source.Play();
                Destroy(gameObject, source.clip.length);
            }
        }
    }
}
