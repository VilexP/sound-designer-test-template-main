using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cum_see : MonoBehaviour
{
    void Update()
    {
        float time = 15f;
        time -= Time.deltaTime;
        if (time < 0)
        {
            time = 0f;
        }
        if (time ==0f)
        {
            bool play = true;
            if (play)
            {
                if (gameObject.transform.rotation.x > 80f)
                {
                    AkSoundEngine.PostEvent("My_Legs", gameObject);
                    play = false;
                }
            }
        }
    }
}
