using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Jugadores : MonoBehaviour
{
    //Variables

    public KeyCode teclaArriba, teclaAbajo;
    private Rigidbody2D rbd2;
   
    void Start()
    {
        rbd2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(teclaArriba) && Pelota.numToques <= 20)
        {
            rbd2.MovePosition(rbd2.position + (Vector2.up * Time.deltaTime * Juego.velJugador + new Vector2(0, (float)Pelota.numToques / 100.0f)));
        }
        if (Input.GetKey(teclaAbajo)) {
            rbd2.MovePosition(rbd2.position + (Vector2.down * Time.deltaTime * Juego.velJugador - new Vector2(0, (float)Pelota.numToques / 100.0f)));
        }
    }
}
