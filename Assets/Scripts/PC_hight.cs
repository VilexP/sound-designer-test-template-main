using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_hight : MonoBehaviour
{
    public Transform PLayer;
    public float hight;
    void Update()
    {
        float hi = PLayer.position.y;
        hight = hi;
        AkSoundEngine.SetRTPCValue("PC_Hight", hi);
    }
}
