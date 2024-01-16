using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pelota : MonoBehaviour    
{
    //Variables
    Juego miJuego;
    public AudioSource reproductor;
    public AudioClip sn1, sn2, snGol, snPared;

    private float compX, compY;

    public static int numToques = 0, golJugadorIzq = 0, golJugadorDer = 0;
    void Start()
    {
        reproductor = GetComponent<AudioSource>();
        miJuego = GameObject.Find("Juego").gameObject.GetComponent<Juego>();

    }

    private void OnTriggerEnter2D(Collider2D colision) {
        if (colision.CompareTag("gol")) {
            Debug.Log("Porteria");
            reproductor.clip = snGol;
            reproductor.Play();
            numToques = 0;

            GameObject nombrePorteria = colision.gameObject;
            if (nombrePorteria.name == "barraIzq") {
                golJugadorDer++;
            }else if(nombrePorteria.name == "barraDer") {
                golJugadorIzq++;
            }
            miJuego.EscribeMarcador();

        }
        if (colision.CompareTag("jugadorIzq")) {
            Debug.Log("Jugador Izq");
            reproductor.clip = sn1;
            reproductor.Play();
            numToques++;

            float alturaColisionIzq = GameObject.Find("jugador1").gameObject.transform.position.y - transform.position.y;
            compX = Mathf.Cos(alturaColisionIzq);
            compY = Mathf.Sin(alturaColisionIzq);

            if (alturaColisionIzq >= 0) {
                GetComponent<Rigidbody2D>().velocity = new Vector2(compX * Juego.velBola + numToques, compY * (Juego.velBola * -1) - (float)numToques);

            }
            else {
                GetComponent<Rigidbody2D>().velocity = new Vector2(compX * Juego.velBola + numToques, compY * (Juego.velBola * -1) + (float)numToques);
            }
        }
        if (colision.CompareTag("jugadorDer"))
        {
            Debug.Log("Jugador Der");
            reproductor.clip = sn2;
            reproductor.Play();
            numToques++;

            float alturaColisionDer = GameObject.Find("jugador2").gameObject.transform.position.y - transform.position.y;
            compX = Mathf.Cos(alturaColisionDer);
            compY = Mathf.Sin(alturaColisionDer);

            if (alturaColisionDer >= 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(compX * (Juego.velBola * -1) - numToques, compY * (Juego.velBola * -1) - (float)numToques);

            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(compX * (Juego.velBola * -1) - numToques, compY * (Juego.velBola * -1) + (float)numToques);
            }
        }
        if (colision.CompareTag("barra")) {
            Debug.Log("Pared");
            reproductor.clip = snPared;
            reproductor.Play();
        }
    }
}
