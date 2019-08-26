﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisualizer : MonoBehaviour
{

    float[] spectrum;
    public float frequency {get; set;}

    float lowFreq;
    float midFreq;
    float highFreq;

    AudioSource music;
    void Start()
    {
        spectrum = new float[256];
        music = GetComponent<AudioSource>();
    }

   void Update()
   {
        music.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);

        for (int i = 1; i < spectrum.Length - 1; i++)
        {
            frequency = spectrum[i];

            lowFreq = frequency >= 20f || frequency <= 200 ? frequency : lowFreq;
        }
   }
}
