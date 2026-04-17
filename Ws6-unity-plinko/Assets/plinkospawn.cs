using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class plinkospawn : MonoBehaviour
{
    public Transform player;
    public GameObject ball;
    float speed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Update()
    {
        player.position = new Vector3((Input.mousePosition.x /40) - 500, player.position.y, player.position.z);
        Debug.Log(Input.mousePosition.x);
        if (Input.GetMouseButtonDown(0))
        {
           Instantiate(ball, new Vector3(player.position.x, player.position.y - player.localScale.y/1.5f, player.position.z),new Quaternion(0,0,0,0));
        }
    }
}
