using UnityEngine;

public class PegScrolling : MonoBehaviour
{
    public Transform Position;
    float Speed = 1f;
    void Update()
    {
        if (Position != null)
        {
            if (Position.position.x > 2.71888)
            {
                Position.position = new Vector3(0, Position.position.y, Position.position.z);
            }
            else
            {
                Position.position += new Vector3(Speed * Time.deltaTime, 0, 0);
            }
        }
    }
}
