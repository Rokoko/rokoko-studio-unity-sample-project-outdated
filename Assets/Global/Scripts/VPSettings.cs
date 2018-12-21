using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VPSettings : MonoBehaviour {

    public Slider CamRotXSlider;
    public Slider CamRotYSlider;
    public Slider CamRotZSlider;

    // Use this for initialization
    void Start () {
        CamRotXSlider.value = PlayerPrefs.GetFloat("cam_rot_x");
        CamRotYSlider.value = PlayerPrefs.GetFloat("cam_rot_y");
        CamRotZSlider.value = PlayerPrefs.GetFloat("cam_rot_z");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void saveButton () {
        PlayerPrefs.SetFloat("cam_rot_x", CamRotXSlider.value);
        PlayerPrefs.SetFloat("cam_rot_y", CamRotYSlider.value);
        PlayerPrefs.SetFloat("cam_rot_z", CamRotZSlider.value);
    }
}
