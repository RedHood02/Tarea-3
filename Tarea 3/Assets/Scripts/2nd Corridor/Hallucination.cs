using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallucination : MonoBehaviour
{
    [SerializeField] Camera mainCamera, hallucinationCamera;
    [SerializeField] Animator lightAnimator, enemyAnimator;
    [SerializeField] AudioSource electricCrackle, whispers, demonicVoice, hearBeat;
}
