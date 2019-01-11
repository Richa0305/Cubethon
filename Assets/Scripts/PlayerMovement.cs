using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public Rigidbody rb;
    private float screenCenterX;

    private void Start()
    {
        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            // get the first one
            Touch firstTouch = Input.GetTouch(0);

            // if it began this frame
            if (firstTouch.phase == TouchPhase.Began)
            {
                if (firstTouch.position.x > screenCenterX)
                {
                    // if the touch position is to the right of center
                    // move right

                    rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                else if (firstTouch.position.x < screenCenterX)
                {
                    // if the touch position is to the left of center
                    // move left

                    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                }
            }
        }



        //if (Input.GetKey("d"))
        //{
        //    rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}

        //if (Input.GetKey("a"))
        //{
        //    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}

        //if (rb.position.y < -1f)
        //{
        //    FindObjectOfType<ManageGame>().EndGame();
        //}
    }
}
