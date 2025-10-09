using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logic; //we cannot drag the logic script into here in Unity, so we have to use code to reference it
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        // the above looks for the first game object in the hierarchy with the tag "logic"
        //then it looks through the components and gets the LogicScript. If it finds one,
        //it will put that in our reference slot.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision) {
        //anything in this function will run once an object first hits the trigger
        //there's also OnTriggerExit and OnTriggerStay, for future reference
        if (collision.gameObject.layer == 3) { //checks if collision happened on the bird's layer
            logic.addScore(1);
        }
    }
}
