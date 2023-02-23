using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameovr : MonoBehaviour
{
    public GameManager scriptt;
    public Text scoreText;
    

    public void hassya(){
        scoreText.text = scriptt.score.ToString();
        
    }
    // score();

    // public void score(){
    //     scriptt.IncreaseScore();
    // }
    public void MainMenu()
   {
        SceneManager.LoadScene("MainMenu");
   }
    public void New(){
        scriptt.Start();
    }
    // Start is called before the first frame update
    void Start()
    {
        hassya();
    }

    // Update is called once per frame
    // s
}
