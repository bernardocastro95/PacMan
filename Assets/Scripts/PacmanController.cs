using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanController : MonoBehaviour
{
    public float speed = 0.4f;
    private Vector2 dest = Vector2.zero;
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    // Start is called before the first frame update
    void Start()
    {
        dest = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);

        if(Input.GetKey(up))
        {
            dest = (Vector2) transform.position + Vector2.up;
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else if(Input.GetKey(down))
        {
            dest = (Vector2) transform.position + Vector2.down;
            transform.eulerAngles = new Vector3(0, 0, 270);
        }
        else if(Input.GetKey(left))
        {
            dest = (Vector2) transform.position + Vector2.left;
            transform.eulerAngles = new Vector2(0, 180);
        }
        else if(Input.GetKey(right))
        {dest = (Vector2) transform.position + Vector2.right;
            transform.eulerAngles = new Vector2(0, 00);
        }

        
    }
    bool valid(Vector2 dir)
        { //This function will stop pacman
            Vector2 pos = transform.position;
            RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
            return (hit.collider == GetComponent<Collider2D>());
        }
    
}
