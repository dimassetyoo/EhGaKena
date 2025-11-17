using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneT1ombol : MonoBehaviour
{
    public TMP_Text teksSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teksSkor.text = "Your Score : " + PlayerPrefs.GetInt("skor").ToString();
    }
    public void Aksi()
    {
        SceneManager.LoadScene("ariefPemain");
    }

    
}
