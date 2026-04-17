using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public static int points = 0;
    public TextMeshPro score;
    private void Update()
    {
        score.text = points.ToString();
    }
}
