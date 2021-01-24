using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KinematicCharacterController;

public class set_switch_reactions : MonoBehaviour
{
    public string switchInGroup;
    public GameObject player;
    private GameObject child;
    bool played = false;
    private void Update()
    {
        child = player.GetComponentInChildren<KinematicCharacterMotor>().sound;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!played)
            {
                AkSoundEngine.SetSwitch("Reactions", switchInGroup, child);
                played = true;
            }
        }
    }
}
