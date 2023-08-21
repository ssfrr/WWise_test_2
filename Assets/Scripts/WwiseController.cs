using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK.Wwise;

public class WwiseController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		//AkSoundEngine.GetWindows
		//for (int i = 0; i < AkSoundEngine.GetDeviceList(); i++) {
		//	uint DeviceID;
		//	print(AkSoundEngine.GetWindowsDeviceName(i, out DeviceID));
		//} // Would probably work well in a dropdown menu, where the user could select device.

		//// Name of my secondary output
		//string nameOfDevice = "HMD";

		//// Get ID of it
		//uint IDofDevice = AkSoundEngine.GetDeviceIDFromName(nameOfDevice);

		//// Create new Output Setting
		//AkOutputSettings newOutput = new AkOutputSettings("Speaker01", IDofDevice);

		//// Add the Output
		//AkSoundEngine.AddOutput(newOutput);
	}


    // Update is called once per frame
    void Update()
    {
        
    }
}
