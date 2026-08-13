using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ItemCollectableBase : MonoBehaviour
{
    public string compareTag = "Player";
    public float timeToHide = 3f;
    //public ParticleSystem particleSystem;
    public GameObject graphicItem;

    [Header("Sounds")]
    public AudioSource audioSound;

    private void OnTriggerEnter(Collider colission)
    {
        if (colission.transform.CompareTag(compareTag))
        {
            Collect();
        }
    }

    protected virtual void Collect()
    {
        if (graphicItem != null) graphicItem.SetActive(false);
        Invoke("HideObject", timeToHide);
        OnCollect();
    }

    private void HideObject()
    {
        gameObject.SetActive(false);
    }

    protected virtual void OnCollect()
    {
        if (audioSound != null) audioSound.Play();
    }
}
