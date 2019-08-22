using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioObj : MonoBehaviour {

    [SerializeField]
    AudioVisualizer audioVisualizer;

    Vector3 initialScale;

    [SerializeField]
    float scaleFactor;

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        float freq = audioVisualizer.frequency;

        Vector3 newScale = new Vector3(freq, freq, freq) * scaleFactor;
        transform.localScale = newScale + initialScale;
    }    
}