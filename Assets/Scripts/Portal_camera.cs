using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_camera : MonoBehaviour
{

    public Transform playerCamera;
    public Transform portal;
    public Transform OtherPortal;
    void Update()
    {
        Vector3 playerOffsetFromPortal = playerCamera.position - OtherPortal.position;
        transform.position = portal.position + playerOffsetFromPortal;

        float angularDiffBetweenPRotation = Quaternion.Angle(portal.rotation, OtherPortal.rotation);

        Quaternion portalRotDiff = Quaternion.AngleAxis(angularDiffBetweenPRotation,Vector3.up);
        Vector3 newCamDir = portalRotDiff * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCamDir, Vector3.up);
    }
}
