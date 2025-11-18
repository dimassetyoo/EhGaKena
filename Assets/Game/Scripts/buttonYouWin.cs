using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class actionButton : MonoBehaviour //YOU WIN
{
    public TMP_Text teksSkor;
    public TMP_Text teksHight;
    public int hightscore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teksSkor.text = "Your Score : " + PlayerPrefs.GetInt("skor").ToString(); //mengambil last score
        if (PlayerPrefs.HasKey("hightscore")) //mengambil hight score
        {
            hightscore = PlayerPrefs.GetInt("hightscore");
            teksHight.text = "Hight Score : " + hightscore.ToString();
        }
        //teksHight.text = "Your Score : " + PlayerPrefs.GetInt("hightscore").ToString();
    }
    public void Aksi()
    {
        SceneManager.LoadScene("ariefPemain"); //pindah scene
    }

    public void aksiMenu()
    {
        SceneManager.LoadScene("ariefMenu");
    }

    
}
