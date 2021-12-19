using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ArrowShoot : MonoBehaviour
{

    public GameObject Arrow;

    public AudioSource _swoosh;

    public int Damage = 1 ;

    public float ArrowSpeed;

    void Start()
    {
        _swoosh = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var arrow = Instantiate(Arrow, transform);
            var position = new Vector3(-0.44f, 0.58f, -0.12f);
            arrow.transform.position = position;
            _swoosh.Play();
        }
        transform.Translate( Vector3.left * Time.deltaTime * ArrowSpeed);
    }
}
