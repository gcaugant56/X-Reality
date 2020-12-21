using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class spawn : MonoBehaviour
{
    public GameObject enemi;
    public GameObject textDead;
    public Text textNbWave;
    public float xPos;
    public float zPos;
    private bool dead = false;
    public int wave = 0;

    void Start()
    {
        textDead.SetActive(false);
        StartCoroutine(spawnEnemi(3));
        textNbWave.text = wave.ToString();
    }

    IEnumerator spawnEnemi(int i)
    {
        yield return new WaitForSeconds(10);
        if (dead == false)
        {
            for (int j = 0; j < i; j++)
            {

                xPos = Random.Range(this.transform.position.x - 20, this.transform.position.x + 20);
                zPos = Random.Range(this.transform.position.z - 20, this.transform.position.z + 20);
                while(xPos < this.transform.position.x + 10 && xPos > this.transform.position.x - 10 || zPos < this.transform.position.z + 10 && zPos > this.transform.position.z - 10)
                {
                    xPos = Random.Range(this.transform.position.x - 20, this.transform.position.x + 20);
                    zPos = Random.Range(this.transform.position.z - 20, this.transform.position.z + 20);
                }
                Instantiate(enemi, new Vector3(xPos, 0, zPos), Quaternion.identity);
            }
            wave++;
            textNbWave.text = wave.ToString();
        }

        Debug.Log(i);
        StartCoroutine(spawnEnemi(i + 1));
    }

    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Contains("mob"))
        {
            textDead.SetActive(true);
            dead = true;

        }
    }

}