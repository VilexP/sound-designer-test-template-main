using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playByTrig_everyTime : MonoBehaviour
{
    public AK.Wwise.Event Event;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Event.Post(gameObject);
        }
    }
}
