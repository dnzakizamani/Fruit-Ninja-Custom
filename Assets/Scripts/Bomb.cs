using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] public AudioSource bombSoundEffect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bombSoundEffect.Play();
            GetComponent<Collider>().enabled = false;
            FindObjectOfType<GameManager>().Explode();
        }
    }

}
