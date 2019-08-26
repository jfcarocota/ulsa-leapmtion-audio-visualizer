using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioObj : MonoBehaviour {

    [SerializeField]
    AudioVisualizer audioVisualizer;

    Vector3 initialScale;

    [SerializeField]
    float scaleFactor;

    [SerializeField]
    public enum FreqType
    {
        Low,
        Mid,
        High
    }

    float freq;

    [SerializeField]
    FreqType freqType;

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {

        switch(freqType)
        {
            case FreqType.Low:
                freq = audioVisualizer.LowFreq;
                break;
            case FreqType.Mid:
                freq = audioVisualizer.MidFreq;
                break;
            case FreqType.High:
                freq = audioVisualizer.HighFreq;
                break;
        }

        Vector3 newScale = new Vector3(freq, freq, freq) * scaleFactor;
        transform.localScale = newScale + initialScale;
    }    
}