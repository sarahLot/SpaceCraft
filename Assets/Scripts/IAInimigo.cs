using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAInimigo : MonoBehaviour
{
    // Start is called before the first frame update

    private float _velocidade = 6.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * _velocidade * Time.deltaTime);


        if ( transform.position.y < -6.0f)
        {
            transform.position = new Vector3(Random.Range(-7.7f, 7.7f), 6.0f, 0);
        }
    }
}
