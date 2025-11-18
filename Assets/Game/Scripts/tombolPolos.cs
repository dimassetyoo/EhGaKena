using UnityEngine;
using UnityEngine.SceneManagement;

public class tombolPolos : MonoBehaviour
{

    //public AudioSource sfxPlay;
    //public AudioSource sfxCredit;
    public AudioSource sfxExit;
    public AudioSource sfxMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aksiPlay()
    {
        //sfxPlay.Play();
        SceneManager.LoadScene("ariefPemain");
    }

    public void aksiCredit()
    {
        //sfxCredit.Play();
        SceneManager.LoadScene("credit");
    }

    public void aksiExit()
    {
        sfxExit.Play();
        Application.Quit();
    }
    public void aksiMenu()
    {
         sfxMenu.Play();
        SceneManager.LoadScene("ariefMenu");
    }
}
