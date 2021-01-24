using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash_fall : MonoBehaviour
{
    public AK.Wwise.Event Event;
    private bool end = true;
    private void OnTriggerEnter(Collider other)
    {
        if (end)
        {
            if (other.tag == "Player")
            {
                Event.Post(gameObject);
                end = false;
            }
        }
    }
}
