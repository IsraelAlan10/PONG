using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public GameObject miPelota;
    Vector3 posicionPelota;
    float velocidad = 1.0f;
    private GameObject jugadorIzq, jugadorDer;
    void Start() {
        jugadorIzq = GameObject.Find("jugador1").gameObject;
        jugadorDer = GameObject.Find("jugador2").gameObject;
    }

    // Update is called once per frame
    void Update() {
        if (Configuracion.tipoJuego == 1 && Niveles.nivel == 1) {
            float deltaY = velocidad * Time.deltaTime + (float)Pelota.numToques / 1100.0f;
            posicionPelota = miPelota.gameObject.transform.position;
            if (posicionPelota.x >= -9 && posicionPelota.x <= 9) {
                transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x,posicionPelota.y, 0),deltaY);
            }else {
                jugadorDer.transform.position = new Vector2(8, 0);
                jugadorIzq.transform.position = new Vector2(-8, 0);
            }
        }
        if (Configuracion.tipoJuego == 1  && Niveles.nivel == 2)
        {
            float deltaY = velocidad * Time.deltaTime + (float)Pelota.numToques / 350.0f;
            posicionPelota = miPelota.gameObject.transform.position;
            if (posicionPelota.x >= -9 && posicionPelota.x <= 9)
            {
                transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, posicionPelota.y, 0), deltaY);
            }
            else
            {
                jugadorDer.transform.position = new Vector2(8, 0);
                jugadorIzq.transform.position = new Vector2(-8, 0);
            }
        }
        if (Configuracion.tipoJuego == 1 && Niveles.nivel == 3)
        {
            float deltaY = velocidad * Time.deltaTime + (float)Pelota.numToques / 200.0f;
            posicionPelota = miPelota.gameObject.transform.position;
            if (posicionPelota.x >= -9 && posicionPelota.x <= 9)
            {
                transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(gameObject.transform.position.x, posicionPelota.y, 0), deltaY);
            }
            else
            {
                jugadorDer.transform.position = new Vector2(8, 0);
                jugadorIzq.transform.position = new Vector2(-8, 0);
            }
        }
    }
}
