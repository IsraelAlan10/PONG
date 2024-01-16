using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Juego : MonoBehaviour
{
    //Variable

    public AudioSource reproductor;
    public Text txtGameOver, txtMenu;
    public AudioClip sndSilba, sndGameOver;
    public GameObject jugador1, jugador2;

    private GameObject txtMarcador, pelota;
    private int signoX, signoY, velocidad = 4;
    private float movVertical, movHorizontal;

    public static float velBola = 5.0f, velJugador = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        txtGameOver.gameObject.SetActive(false);
        txtMenu.gameObject.SetActive(false);
        reproductor = GetComponent<AudioSource>();

        txtMarcador = GameObject.Find("txtMarcador");
        txtMarcador.GetComponent<Text>().text = "0 - 0";

        pelota = GameObject.Find("pelota");
        movHorizontal = Random.Range(0, 10);
        Debug.Log("Movimiento horizontal: " + movHorizontal);
        if (movHorizontal > 5) {
            signoX = 1;
        } else {
            signoX = -1;
        }
        StartCoroutine(pitaInicio());
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Niveles");
        }
        if (Pelota.golJugadorDer == 3 || Pelota.golJugadorIzq == 3) {
            if (Input.GetKey(KeyCode.Space)) {
                Pelota.golJugadorDer = 0;
                Pelota.golJugadorIzq = 0;
                SceneManager.LoadScene("Main");
            }
            if (Input.GetKey(KeyCode.LeftAlt)) {
                Pelota.golJugadorDer = 0;
                Pelota.golJugadorIzq = 0;
                SceneManager.LoadScene("Inicio");
            }
        }
    }

    IEnumerator pitaInicio() {
        yield return new WaitForSeconds(2.0f);
        LanzaPelota();
    }
    IEnumerator mostrarOp() {
        yield return new WaitForSeconds(2.5f);
        txtMenu.gameObject.SetActive(true);
    }
    public void EscribeMarcador() {
        txtMarcador.GetComponent<Text>().text = Pelota.golJugadorIzq.ToString() + " - " + Pelota.golJugadorDer.ToString();
        if (Pelota.golJugadorIzq == 3 || Pelota.golJugadorDer == 3) {
            txtGameOver.gameObject.SetActive(true);
            reproductor.clip = sndGameOver;
            reproductor.Play();
            StartCoroutine(mostrarOp());

        }else {
            jugador1.transform.position = new Vector2(jugador1.transform.position.x, 0);
            jugador2.transform.position = new Vector2(jugador2.transform.position.x, 0);
            StartCoroutine(pitaInicio());
        }
    }
    public void LanzaPelota() {
        reproductor.clip = sndSilba;
        reproductor.Play();
        pelota.transform.position = gameObject.transform.position = new Vector2(0,0);

        movVertical = Random.Range(0, 10);
        Debug.Log("Moviiento vertical: " + movVertical);
        if (movVertical > 5) {
            signoY= 1;
        }
        else {
            signoY= -1;
        }

        pelota.GetComponent<Rigidbody2D>().velocity = new Vector2(signoX * velocidad, signoY * velocidad);
    }
}
