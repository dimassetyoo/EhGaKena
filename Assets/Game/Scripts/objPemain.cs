using UnityEngine;

public class objPemain : MonoBehaviour
{
    public bool isGrounded;
    public float jumpForce = 12.0f; //variabel untuk tinggi lomapan
    public int health = 10;
    public int skor;
    public Vector2 mousePosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        if (collision.gameObject.CompareTag("lantai"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("lantai"))
        {
            isGrounded = false;
        }
    }
}
