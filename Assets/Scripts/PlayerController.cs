using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float velocity;

    private Rigidbody rigidBody;
    public Text scoreText, winText;

    private int score;

    void Start()
    {
        score = 0;
        rigidBody = GetComponent<Rigidbody>();

        setScoreText();
    }

    void FixedUpdate()
    {
        
        float h_axis = Input.GetAxis("Horizontal");
        float v_axis = Input.GetAxis("Vertical");

        rigidBody.AddForce(new Vector3(h_axis, 0.0f, v_axis) * velocity);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectables"))
        {
            score += 1;
            setScoreText();
            other.gameObject.SetActive(false);
        }
    }

    void setScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
        if (score >= 12)
        {
            winText.text = "Ganaste!";
        }
    }
}

