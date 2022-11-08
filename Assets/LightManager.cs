using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightManager : MonoBehaviour
{

    public static LightManager instance;
    private Light2D[] lights;
    private List<float> startingIntensities = new List<float>();

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        lights = GetComponentsInChildren<Light2D>();
        for (int i = 0; i < lights.Length; i++)
        {
            startingIntensities.Add(lights[i].intensity);
        }
    }

    public void TurnOff()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].intensity = 0f;
        }
    }

    public void TurnDim()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].intensity = startingIntensities[i] / 1.5f;
        }
    }

    public void TurnBright()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].intensity = startingIntensities[i];
        }
    }
    


}
