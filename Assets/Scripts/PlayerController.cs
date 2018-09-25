using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float speed;
    private int count;
    public Text countText;
    public Text winText;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        setCountText();
        winText.text = "";
    }

    private void FixedUpdate()
    {
        // This is a comment
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed );
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag( "PickUp" ) ) 
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
            if ( count >= 12 ) {
                winText.text = "You win !";
            }
        }
    }

    private void setCountText()
    {
        countText.text = "Count: " + count.ToString();

    }

}
