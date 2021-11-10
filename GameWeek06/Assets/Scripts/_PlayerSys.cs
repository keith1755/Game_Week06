using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class _PlayerSys : MonoBehaviour
{
    public TMP_Text _Bomb;
    public int bomb;

    public GameObject breakParticle, hit;

    public Transform SpawnPos;

    public float timer;
    public TMP_Text _timer;
    public GameObject _gameOver;

    public bool GameStart, Escape;
    public GameObject EscapeUI;

    public AudioSource _HitSound;


    void Start()
    {
        
    }

    void Update()
    {
        _Bomb.text = bomb.ToString("0");
        _timer.text = timer.ToString("000");

        if (GameStart)
        {
            //Timer
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                GameOver();
            }
        }

        if (Escape)
        {
            FinishGame();
        }

    }

    public void Gethit()
    {
        gameObject.transform.position = new Vector3(SpawnPos.position.x, SpawnPos.position.y, SpawnPos.position.z);
        _HitSound.Play();
    }

    public void AddBomb()
    {
        bomb += 1;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Door")
        {
            //Debug.Log("Door");
            if(bomb >= 1)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    bomb -= 1;
                    Instantiate(breakParticle, other.transform.position, Quaternion.identity);
                    Destroy(other.gameObject);
                }
            }
        } 
    }

    void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.collider.tag == "Trap")
        {
            Gethit();
        }

    }

    void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        _gameOver.SetActive(true);
    }

    void FinishGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        EscapeUI.SetActive(true);
    }

}
