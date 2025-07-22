using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine; 
using UnityEngine.UI;

public class FlipMover : MonoBehaviour
{
    public AudioSource moveClickAudioSource;
    public AudioSource stopClickAudioSource;
    public AudioSource flipClickAudioSource;

    public AudioClip stopClickAudioClip;

    public List<AudioClip> flipClickAudioClips;

    public Slider staminaSlider;

    public float speed;
    public float direction = 1f;

    public bool moveClick;
    public bool stopClick;

    private float currentStamina;
    private float exhaustRate;
    public float exhaustedSpeed;

    // Start is called before the first frame update
    void Start()
    {
        stopClickAudioSource.clip = stopClickAudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveClick)
        {
            transform.position += Vector3.right * speed * Time.deltaTime * direction;
            currentStamina -= exhaustRate * Time.deltaTime;
        }

        if (stopClick)
        {
            moveClick = false;
            stopClickAudioSource.Play();
        }
    }

    public void OnMoveClick()
    {
        Debug.Log("Move was Clicked");

        moveClick = true;
        moveClickAudioSource.Play();

    }

    public void OnStopClick()
    {
        Debug.Log("Stop was Clicked");

        stopClick = true;
    }

    public void OnFlipClick()
    {
        direction *= -1f;

        //Take our clips

        //choose one randomly

        //Get a random number from 0 to the size of the list minus 1
        //make sure you take into account the exclusive nature of the maximum parameter with Random.Range
        int randomIndex = UnityEngine.Random.Range(0, flipClickAudioClips.Count);
        AudioClip randomlyChosenClip = flipClickAudioClips[randomIndex];

        flipClickAudioSource.PlayOneShot(randomlyChosenClip);
    }

}
