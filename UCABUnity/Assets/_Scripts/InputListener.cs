using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{

    public float hor;

    [HideInInspector]public float ver;

    private float ejemplo;

    [SerializeField] private float ejemplo2;
    public GameObject prefab;
  

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        float vertical = 0;

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        hor = horizontal;
        ver = vertical;

        Vector3 movement = new Vector3(horizontal, vertical, 0);

        transform.position += movement * Time.deltaTime * 5f;


        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(prefab, transform.position, transform.rotation);
            Singleton.instancia.SingletonMethod();
        }
    }
}
