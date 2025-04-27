using UnityEngine;
[RequireComponent(typeof(AudioSource), typeof(PlayerMovement))]
public class Footsteps : MonoBehaviour
{
    public AudioClip stepClip;
    private AudioSource src;
    private PlayerMovement pm;
    private float timer;

    void Start()
    {
        src = GetComponent<AudioSource>();
        pm = GetComponent<PlayerMovement>();
        src.loop = false;
    }

    void Update()
    {
        if (pm.IsMoving()) 
        {
            timer += Time.deltaTime;
            if (timer > 0.5f)
            {
                src.PlayOneShot(stepClip);
                timer = 0;
            }
        }
    }
}
