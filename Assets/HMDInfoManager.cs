using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Device active " + XRSettings.isDeviceActive);
        Debug.Log("Device name " + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No headset plugged!");
        }
        else if (XRSettings.isDeviceActive && 
                 (XRSettings.loadedDeviceName == "Mock HMD" || XRSettings.loadedDeviceName == "MockHMDDisplay"))
        {
            Debug.Log("Using Mock HMD");
        }
        else
        {
            Debug.Log("We have headset." + XRSettings.loadedDeviceName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
