using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playBy_trigger : MonoBehaviour
{
    public AK.Wwise.Event Event;
    bool play = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (play)
            {
                Event.Post(gameObject);
                play = false;
            }
        }
    }
}
