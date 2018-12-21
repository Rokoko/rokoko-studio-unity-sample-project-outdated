using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLights : MonoBehaviour {

    public GameObject lights;
    public GameObject buildings;
    public bool lightsOn = true;

    // Use this for initialization
    public void toggleLights () {
        Debug.Log("Should toggle");
        if (lightsOn == true) {
            lights.SetActive(false);
            buildings.SetActive(true);
            lightsOn = false;
        } else {
            lights.SetActive(true);
            buildings.SetActive(false);
            lightsOn = true;
        }
    }
}
