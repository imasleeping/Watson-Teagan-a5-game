using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreArea : MonoBehaviour
{
    public int value = 25;
    public TextMeshPro scoretext;
    private void Start()
    {
        scoretext.text = value.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        Points.points += value;
        Destroy(collider2D.gameObject);
    }
}
