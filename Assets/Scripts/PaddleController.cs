using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    //private void Update()
    //{
    //    // Deklarasi variabel position
    //    // jika tidak ada input maka berhenti/zero
    //    Vector2 movement = Vector2.zero;

    //    // ambil input
    //    if (Input.GetKey(upKey))
    //    {
    //        // gerakan ke atas
    //        //speed = new Vector2(0, 1f);
    //        movement = Vector2.up * speed;
    //    }
    //    else if (Input.GetKey(downKey))
    //    {
    //        // gerakan ke bawah
    //        //speed = new Vector2(0, -1f);
    //        movement = Vector2.down * speed;
    //    }
    //    // gerakan objek pake input
    //    transform.Translate(movement * Time.deltaTime);
    //}

    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            if (gameObject.transform.position.y < 3.4f)
            {
                Debug.Log("Kecepatan Paddle: " + speed);
                return Vector2.up * speed;
            }
        }
        else if (Input.GetKey(downKey))
        {
            if (gameObject.transform.position.y > -3.4f)
            {
                Debug.Log("Kecepatan Paddle: " + speed);
                return Vector2.down * speed;
            }
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        //transform.Translate(movement * Time.deltaTime);
        rig.velocity = movement;
    }
}