using UnityEngine;

public class CubeController : MonoBehaviour
{   
    public Transform cube;
    private float timer = 0;

    private void RotateCube()
    {
        float rotation = 20.0f * Time.deltaTime;
        cube.Rotate(Vector3.one * rotation);
    }

    private void ScaleCube()
    {
        cube.localScale = Vector3.one * (3 + 2*Mathf.Sin(Time.time));
    }

    private void TranslateCube()
    {
        if(timer >= 3f)
        {
            cube.Translate(Vector3.up * Random.Range(-2f, 2f));
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {   
        RotateCube();
        ScaleCube();
        TranslateCube();
    }
}
