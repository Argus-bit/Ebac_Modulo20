using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ItemCollatableBase : MonoBehaviour
{
    public string compareTag = "Player";
    public float timeToHide = 3;
    public GameObject graphicItem;

    [Header("Sounds")]
    public AudioSource audioSource;

    //muda a Hierarquida de dentro do projeto
    private void Awake()
    {
       if(GetComponent<ParticleSystem>() != null) GetComponent<ParticleSystem>().transform.SetParent(null);
       if(audioSource != null) audioSource.transform.SetParent(null);
    }
    //muda a Hierarquida de dentro do projeto

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.CompareTag(compareTag))
        {
            Collect();
        }
    }
    protected virtual void Collect()
    {
        if(graphicItem !=null) graphicItem.SetActive(false);
        gameObject.SetActive(false);
        OnCollect();
    }
    private void HideObject()
    {
        gameObject.SetActive(false);
    }
    protected virtual void OnCollect()
    {
        if (audioSource != null) audioSource.Play();
    }
}