using UnityEngine;

public class JumperTahta : MonoBehaviour
{
    [SerializeField] private Vector3 jumpPower;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().AddForce(jumpPower);
        }
    }
}