using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    //private void Update()
    //{
    //    //transform.position = transform.position + (new Vector3(1f, 0, 0) * Time.deltaTime);
    //    //transform.Translate(new Vector3(1f, 0, 0) * Time.deltaTime);

    //    transform.Translate(speed * Time.deltaTime);
    //}

    private void Update()
    {
        //transform.Translate(speed * Time.deltaTime);
    }
}