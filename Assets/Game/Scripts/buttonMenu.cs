using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class buttonMenu : MonoBehaviour
{
    public AudioSource sfxPlayAgain;
    public AudioSource sfxMenu;
    public AudioSource sfxExit;
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
                // StartCoroutine(TungguSuara());
    
        SceneManager.LoadScene("ariefPemain");
    }

    public void aksiCredit()
    {
        SceneManager.LoadScene("credit");
    }

    public void aksiExit()
    {
                sfxExit.Play();

        Application.Quit();
    }
    public void aksiMenu()
    {        sfxMenu.Play();

        SceneManager.LoadScene("ariefMenu");
    }

    public void PutarSuaraPlayAgain()
    {
         sfxPlayAgain.Play();

    }

   /* public IEnumerator TungguSuara()
    {
        Debug.Log("Tunggu Suara Jalan");
                yield return new WaitForSeconds(3);
    }*/
}
