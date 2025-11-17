using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonMenu : MonoBehaviour
{
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
