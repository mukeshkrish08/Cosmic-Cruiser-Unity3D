using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerscore;
    public Text scoretext;
    public static logicScript instance;
    public GameObject gameoverscene;
    
    public void Awake()
    {
        instance = this;
    }
    public void addScore()
    {
        playerscore++;
        scoretext.text = playerscore.ToString();
    }
    public void gameOverScreen() 
    {
        gameoverscene.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
