using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Player.Singleton.Core.Singleton;

public class PlayerController : Singleton<PlayerController>
{

    //Publics
    [Header("Lerp")]
    public Transform target;
    public float lerpSpeed = 5f;

    public float speed = 5f;
    public string tagToCheckEnemy = "Enemy";
    public string tagToCheckEndLine = "EndLine";

    public bool invincible = false;

    public GameObject endScreen;

    //Privates
    private bool _canRun;
    private Vector3 _position;
    private float _currentSpeed;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
        ResetSpeed();
    }

    void Update()
    {
        if (!_canRun) return;

        _position = target.position;
        _position.y = transform.position.y;
        _position.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, _position, lerpSpeed * Time.deltaTime);
        transform.Translate(transform.forward * _currentSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == tagToCheckEnemy)
        {
            if(!invincible) EndGame();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == tagToCheckEndLine)
        {
            if(!invincible) EndGame();
        }
    }

    private void EndGame()
    {
        _canRun = false;
        endScreen.SetActive(true);
    }

    public void StartToRun()
    {
        _canRun = true;
    }

    #region Power Ups
    public void SetPowerUpText(string text)
    {
        //UITextPowerUp.Text = text;
    }

    public void PowerSpeedUp(float f)
    {
        _currentSpeed = f;
    }

    public void ResetSpeed()
    {
        _currentSpeed = speed;
    }

    public void SetInvincible(bool b)
    {
        invincible = b;
    }

    #endregion

}
