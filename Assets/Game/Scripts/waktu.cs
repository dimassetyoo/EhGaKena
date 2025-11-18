using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float time = 60f;
    public TMP_Text timerText;
    public bool isCounting = true;
    public objPemain objPemain;

    private Coroutine timerCoroutine;

    private void Start()
    {
        // tampilkan waktu awal
        timerText.text = "Waktu : " + time.ToString();

        // mulai hitung mundur otomatis
        timerCoroutine = StartCoroutine(HitungTimer());
    }

    IEnumerator HitungTimer()
    {
        //untuk hitung mundur waktu
        while (isCounting && time > 0)
        {
            yield return new WaitForSeconds(1f);

            time -= 1;
            timerText.text = "Waktu : " + time.ToString();
        }

        // kondisi jika waktu habis atau bisa ketika waktu menyentuh waktu tertentu
        if (time <= 0)
        {
            isCounting = false;
            timerText.text = "Waktu : 0";
            PlayerPrefs.SetInt("skor", objPemain.skor);
            PlayerPrefs.Save();
            objPemain.simpanHightSkor();
            SceneManager.LoadScene("ariefYouWin");
        }
    }
}
