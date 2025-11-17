using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class objPemain : MonoBehaviour
{
    public bool isGrounded;
    public float jumpForce = 12.0f; //variabel untuk tinggi lomapan
    public float health = 10;
    public int maxHealth;
    public int skor;
    public Vector2 mousePosition;
    public Image healthImage;
    public TMP_Text teksSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health= Mathf.Clamp(health, 0, 10);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("lompat");
            jump();
        }

        move();        
    }

    public void move()
    {
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //untuk mengatur posisi
        mousePosition = new Vector2(worldMousePosition.x, transform.position.y); //kalau sesuai posisi pakai transform.position
        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        mousePosition.x = Mathf.Clamp(mousePosition.x, minimum.x, maximum.x);
        mousePosition.y = Mathf.Clamp(mousePosition.y, minimum.y, maximum.y);
        transform.position = mousePosition;
    }

    public void jump()
    {
        if (isGrounded)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        } else
        {
            Debug.Log("Lagi lompat");
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            isGrounded = true;
        }

        
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            isGrounded = false;
        }
    }

    public void KurangNyawa()
    {
        if (health > 0)
        {
            health = health -1;
        healthImage.fillAmount = health/10;
        } else
        {
            PlayerPrefs.SetInt("skor", skor);
            PlayerPrefs.Save();
            SceneManager.LoadScene("gameOver");
        }
        
    }

    public void tambahNyawa()
    {
        
            health = health +1;      
        
    }

     public void TambahSkor()
    {
        skor= skor +1;
        teksSkor.text = "Skor : " + skor.ToString();
    }
}
