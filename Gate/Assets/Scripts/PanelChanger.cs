using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{ 
    public GameObject locationSelect;
    public GameObject egyptCube;
    public GameObject galileeCube;
    public GameObject jerusalemCube;


    // Use this for initialization
    void Awake()
    {
        this.locationSelect = GameObject.FindGameObjectWithTag("Location Select");
        this.egyptCube = GameObject.FindGameObjectWithTag("Egypt Cube");
        this.galileeCube = GameObject.FindGameObjectWithTag("Galilee Cube");
        this.jerusalemCube = GameObject.FindGameObjectWithTag("Jerusalem Cube");
    }

    public void LocationSelectAndEgyptCubeSwitch()
    {
        this.locationSelect.SetActive(false);
        this.galileeCube.SetActive(false);
        this.jerusalemCube.SetActive(false);
    }

    public void LocationSelectAndGalileeCubeSwitch()
    {
        this.locationSelect.SetActive(false);
        this.egyptCube.SetActive(false);
        this.jerusalemCube.SetActive(false);
    }
    public void LocationSelectAndJerusalemCubeSwitch()
    {
        this.locationSelect.SetActive(false);
        this.egyptCube.SetActive(false);
        this.galileeCube.SetActive(false);
    }
}