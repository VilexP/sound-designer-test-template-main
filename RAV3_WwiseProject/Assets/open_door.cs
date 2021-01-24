using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_door : MonoBehaviour
{
    private bool inTrigg;
    public AkRoomPortal portal;
    public GameObject text;

    private void Start()
    {

        portal.Close();
    }
    private void Update()
    {
        if (inTrigg)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                portal.Open();
                gameObject.GetComponent<Animation>().Play();
                AkSoundEngine.PostEvent("Open_Door", gameObject);
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            text.SetActive(true);
            inTrigg = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            text.SetActive(false);
        }
    }
}
