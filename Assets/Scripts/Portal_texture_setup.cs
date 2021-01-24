using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_texture_setup : MonoBehaviour
{

    public Camera cameraB;
    public Material cameraBMaterial;
    void Start()
    {
        if (cameraB.targetTexture!= null)
        {
            cameraB.targetTexture.Release();

        }
        cameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraBMaterial.mainTexture = cameraB.targetTexture;
    }

}
