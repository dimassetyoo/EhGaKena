using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class buttonMenu : MonoBehaviour //GAME OVER
{
    public TMP_Text teksSkor;
    public TMP_Text teksHight;
    public int hightscore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teksSkor.text = "Your Score : " + PlayerPrefs.GetInt("skor").ToString();
        if (PlayerPrefs.HasKey("hightscore"))
        {
            hightscore = PlayerPrefs.GetInt("hightscore");
            teksHight.text = "Hight Score : " + hightscore.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aksiPlay()
    {
        SceneManager.LoadScene("ariefPemain");
    }

    public void aksiCredit()
    {
        SceneManager.LoadScene("credit");
    }

    public void aksiExit()
    {
        Application.Quit();
    }
    public void aksiMenu()
    {
        SceneManager.LoadScene("ariefMenu");
    }
}
