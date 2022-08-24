namespace ArionDigital
{
    using UnityEngine;

    public class Shooter : MonoBehaviour
    {
        //---------------------- PROPIEDADES SERIALIZADAS ----------------------

        [SerializeField] GameObject bullet;         // La bala que se instanciará
        [SerializeField] Transform spawnPoint;      // El objeto que los hará aparecer

        [SerializeField] float shootForce = 1500;   // La Fuerza disparo
        [SerializeField] float shootRate = 0.5f;    // La velocidad de repetición de disparo

        [SerializeField] AudioSource shootAudio;    // El sonido que hará al disparar

        //---------------------- PROPIEDADES PRIVADAS ----------------------

        private float shootRateTime = 0;


        private void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {

                if (Time.time > shootRateTime)
                {
                    GameObject newBullet;
                    shootAudio.Play();
                    newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                    newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shootForce);

                    shootRateTime = Time.time + shootRate;

                    Destroy(newBullet, 3f);
                }
            }
        }
    }
}