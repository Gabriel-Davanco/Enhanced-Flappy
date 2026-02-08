using UnityEngine;

public class HandlePipes : MonoBehaviour
{

    [SerializeField] float spd = 2f;
    void Update()
    {
        //Pipes mexendo
        transform.position += new Vector3(spd * (-1), 0, 0) * Time.deltaTime;
    }

    //destroir instancias
    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.CompareTag("Destroy"))
        {
            Debug.Log("Pipe passou");
            Destroy(gameObject);
        }
    }
}
