using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK.Wwise;

public class RoutedListener : MonoBehaviour
{
    public int ListenerIdx = 1;

    void Awake()
    {
        AkSoundEngine.SetRTPCValue("ListenerIdx", ListenerIdx, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
