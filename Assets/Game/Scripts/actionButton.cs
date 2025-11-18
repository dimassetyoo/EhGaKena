using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneT1ombol : MonoBehaviour
{
    public AudioSource sfxMenu;
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
        //teksHight.text = "Your Score : " + PlayerPrefs.GetInt("hightscore").ToString();
    }
    public void Aksi()
    {
        SceneManager.LoadScene("ariefPemain");
    }

    public void aksiMenu()
    {
        sfxMenu.Play();
        SceneManager.LoadScene("ariefMenu");
    }

    
}
