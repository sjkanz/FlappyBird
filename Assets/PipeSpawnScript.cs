using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3; //how many seconds between each pipe spawned
    private float timer = 0; //private bc we aren't chnaging it in the editor or anywhere else
    public float heightOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else {
            spawnPipe();
            timer = 0;
        }
        //transform.position and transform.rotation makes the spawned things the same as the spawner
    }

    void spawnPipe() {
        //we want the pipes to change in the y direction, not the x direction, so offsets
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        //Instantiate(pipe, transform.position, transform.rotation);
        //we modify this Instantiate because this one only spits out everything in horizontal line in the middle
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        //transform.position.x keeps x the same as the spawn point, Random.Range picks from the given range, 0 is for z value
    }
}
