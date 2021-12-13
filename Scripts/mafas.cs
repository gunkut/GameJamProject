using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mafas : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float velocity = 0.5f;
    public Animator mafas_animation;
    public int fish = 0;
    public Text fish_text;
    public int bird = 0;
    public Text bird_text;
    public int cow = 0;
    public Text cow_text;
    public int sheep = 0;
    public Text sheep_text;
    public int cock = 0;
    public Text cock_text;
    public int health = 100;
    public Text health_text;
    // Start is called before the first frame update
    void Start()
    {
        health_text.text = "Can:" + health.ToString();
        fish_text.text = "Balik:"+fish.ToString();
        bird_text.text = "Kuþ:" + bird.ToString();
        cow_text.text = "Ýnek:" + cow.ToString();
        sheep_text.text = "Kuzu:" + sheep.ToString();
        cock_text.text = "Horoz:" + cock.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        horizontal= Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal* velocity, 0, 0);

        vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vertical * velocity, 0);

        //Change_Direction();

        bool IsWalking = false;

        if (horizontal != 0)
            IsWalking = true;
        if (horizontal == 0)
            IsWalking = false;


        mafas_animation.SetBool("IsWalk", IsWalking);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="balik")
        {
            Destroy(collision.gameObject);
            fish++;
            fish_text.text = "Fish:" + fish.ToString();
            if(fish==10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Destroy(gameObject);
            }
        }
        if (collision.tag == "kus")
        {
            Destroy(collision.gameObject);
            bird++;
            bird_text.text = "Kuþ:" + bird.ToString();
        }
        if (collision.tag == "horoz")
        {
            Destroy(collision.gameObject);
            cock++;
            cock_text.text = ":" + cock.ToString();
        }
        if (collision.tag == "inek")
        {
            Destroy(collision.gameObject);
            cow++;
            cow_text.text = "Ýnek:" + cow.ToString();
        }
        if (collision.tag == "kuzu")
        {
            Destroy(collision.gameObject);
            sheep++;
            sheep_text.text = "Kuzu:" + sheep.ToString(); 
        }
        if (collision.tag == "kral inek")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (collision.tag == "diken")
        {
            health -= 10;
            health_text.text = "Can:" + health.ToString();
        }
    }
    

    void Change_Direction()
    {
        if (horizontal > 0)
            transform.localScale = new Vector3(1, 1, 0);
        else if (horizontal < 0)
            transform.localScale = new Vector3(-1, 1, 0);

        if (vertical > 0)
        {
            float x = transform.localScale.x;
            transform.localScale = new Vector3(x, 1, 1);
        }
    }
}
