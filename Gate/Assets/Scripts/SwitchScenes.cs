using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public GameObject locationSelect;

    void Awake()
    {
        this.locationSelect = GameObject.FindGameObjectWithTag("Location Select");
    }

    public void Scene1AndEgyptSwitch()
    {
        this.locationSelect.SetActive(false);
        SceneManager.LoadScene("Egypt");
    }

    public void Scene1AndGalileeSwitch()
    {
        this.locationSelect.SetActive(false);
        SceneManager.LoadScene("Galilee");
    }

    public void Scene1AndJerusalemSwitch()
    {
        this.locationSelect.SetActive(false);
        SceneManager.LoadScene("Jerusalem");
    }
}
