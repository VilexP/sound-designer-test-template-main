using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KinematicCharacterController;

public class poral_Teleportal : MonoBehaviour
{
    public KinematicCharacterMotor kin;
    public Transform rieciver;

    private bool playerOverlapping;
    void Update()
    {
        if (playerOverlapping)
        {
            //rig.interpolation = RigidbodyInterpolation.None;
            //rig.transform.position = rieciver.position;
            //rig.interpolation = RigidbodyInterpolation.Interpolate;
            Vector3 portalToPlayer = kin.transform.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);
            //player.position = rieciver.position;

            if (dotProduct < 0f)
            {
                print("in");
                float rotDiff = -Quaternion.Angle(transform.rotation, rieciver.rotation);
                rotDiff += 180;
                kin.transform.Rotate(Vector3.up, rotDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotDiff, 0f)*portalToPlayer;
                Vector3 pos = rieciver.position;
                //player.position = rieciver.position + positionOffset;
                kin.SetPosition(pos);

                playerOverlapping = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerOverlapping = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerOverlapping = true;
        }
    }
}
