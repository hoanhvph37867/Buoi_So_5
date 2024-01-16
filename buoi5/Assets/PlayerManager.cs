using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    Rigidbody2D rigidbody2D;
    Transform transform;


    private void Start(){
        rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        transform = this.gameObject.GetComponent<Transform>();
    }

    float movePrefix = 6;
    private void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            rigidbody2D.AddForce(Vector2.up, ForceMode2D.Impulse);
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            
            rigidbody2D.AddForce(Vector2.left, ForceMode2D.Impulse);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            rigidbody2D.AddForce(Vector2.right, ForceMode2D.Impulse);
        }
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision )
    {
        if (collision.gameObject.tag == "coin"){
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Va cham vao: " + other.gameObject.tag);
    }

    Rigidbody2D rigidbody2d;



}
