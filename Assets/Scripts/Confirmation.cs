using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Confirmation : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
