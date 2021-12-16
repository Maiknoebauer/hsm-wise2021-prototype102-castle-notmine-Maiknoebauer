using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ArrowController : MonoBehaviour
{
    private GoodGuyController _goodGuyController;
    private BadGuyController _badGuyController;

    public int Damage = 1 ;
    private GameManager _gameManager;
    void Start()
    {
        Destroy(gameObject,10f);

        _gameManager = FindObjectOfType<GameManager>();
        _goodGuyController = FindObjectOfType<GoodGuyController>();
        _badGuyController = FindObjectOfType<BadGuyController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GoodGuy")
        {
            _goodGuyController.TakeDamage(Damage);
            Destroy(other.gameObject);
            ScoreScript.scoreValue = 0;
            _gameManager.GameOver();
            Destroy(gameObject);
        }
        if (other.tag == "BadGuy")
        {
            ScoreScript.scoreValue += 1;
            _badGuyController.TakeDamage(Damage);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

}
