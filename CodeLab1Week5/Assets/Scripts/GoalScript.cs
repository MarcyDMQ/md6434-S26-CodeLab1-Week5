using UnityEngine;

public class GoalScript : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("great job");

        ASCIILevelLoader.instance.CurrentLevel++;
    }
}
