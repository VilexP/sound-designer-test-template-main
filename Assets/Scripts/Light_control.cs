using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_control : MonoBehaviour
{

    public AK.Wwise.Event play;

    public float constan;
    public float Timer;
    public float intent;
    private float chance;

    private void Start()
    {
        chance = Random.Range(0.05f, 5f);
        Timer = Random.Range(5f, 10f);
        play.Post(gameObject);
    }

    private void Update()
    {


        if (gameObject.GetComponent<Light>().intensity != constan)
        {
            gameObject.GetComponent<Light>().intensity = constan;
        }

        if (Timer > 0)
        {
            Timer -= (chance * Time.deltaTime);
        }


        if (Timer < 0)
        {
            Timer = 0;
        }

        if (Timer < 1)
        {
            AkSoundEngine.SetSwitch("Light_glitch", "Off", gameObject);
            gameObject.GetComponent<Light>().intensity = intent;
            intent = 0f;

        }

        if (Timer > 1)
        {
            AkSoundEngine.SetSwitch("Light_glitch", "On", gameObject);
            gameObject.GetComponent<Light>().intensity = intent;
            intent = 1f;
        }

        if (Timer == 0)
        {
            chance = Random.Range(0.1f, 15f);
            Timer = Random.Range(2f, 20f);
        }


    }

}