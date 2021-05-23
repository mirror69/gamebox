using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RIngScript : MonoBehaviour
{
    [Header("Script Ref's")]
    [SerializeField] private PlayerController playerController;
    [SerializeField] private float _newJumpForce = 20f;
    [Header("GameObjects Ref's")]
    [SerializeField] private GameObject Trail1;
    [SerializeField] private GameObject Trail2;
    [SerializeField] private GameObject ArrowSprite;
    private bool tookRing = false;
    public bool TookRing
    {
        get => tookRing;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            tookRing = true;
            AudioManager_script.Instance.RingSound();
            playerController.playerMovement.JumpForce = _newJumpForce;
            gameObject.SetActive(false);
            Trail1.SetActive(true);
            Trail2.SetActive(true);
            ArrowSprite.SetActive(true);
        }
    }
}