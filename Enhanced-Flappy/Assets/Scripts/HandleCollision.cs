using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleCollision : MonoBehaviour
{
    [SerializeField] GameObject pipeSection;
    float hgt = 0;


    private void Reset()
    {
        SceneManager.LoadScene("MainGame");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collide")) Reset();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            hgt = Random.Range(-4f, 2f);
            Instantiate(pipeSection, new Vector3(44.6f, hgt, 14f), Quaternion.identity);
        }
        
    }

}
