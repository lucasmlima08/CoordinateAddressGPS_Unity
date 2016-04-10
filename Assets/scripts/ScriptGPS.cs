using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptGPS : MonoBehaviour {

    public Text Status;
	public Text EnabledByUser;
    public Text Latitude;
    public Text Longitude;
    public Text Altitude;
    public Text HorizontalAccuracy;
	public Text VerticalAccuracy;
    public Text TimeStamp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if ((Input.location.status+"").Equals ("Running")) 
		{
			Status.text = Input.location.status + "";
			EnabledByUser.text = "Enabled By User: " + Input.location.isEnabledByUser;
			Latitude.text = "Latitude: " + Input.location.lastData.latitude;
			Longitude.text = "Longitude: " + Input.location.lastData.longitude;
			Altitude.text = "Altitude: " + Input.location.lastData.altitude;
			HorizontalAccuracy.text = "Horizontal Accuracy: " + Input.location.lastData.horizontalAccuracy;
			VerticalAccuracy.text = "Vertical Accuracy: " + Input.location.lastData.verticalAccuracy;
			TimeStamp.text = "Time Stamp: " + Input.location.lastData.timestamp;

			Input.location.Stop();
			Input.location.Start();
		}
    }

    public void eventStart()
    {
		clear ();
        Input.location.Start();
    }

    public void eventStop()
    {
        Input.location.Stop();
		clear();
    }

	private void clear()
	{
		Status.text = "Stopped";
		EnabledByUser.text = "Enabled By User: " + Input.location.isEnabledByUser;
		Latitude.text = "Latitude: 0";
		Longitude.text = "Longitude: 0";
		Altitude.text = "Altitude: 0";
		HorizontalAccuracy.text = "Horizontal Accuracy: 0";
		VerticalAccuracy.text = "Vertical Accuracy: 0";
		TimeStamp.text = "Time Stamp: 0";
	}
}
