using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;
    public float hazardcount;
    public float spawnwait;
    public float startwait;
    public float wavewait;
    float[] hazardnumber = new float[3] { 1, 2, 3 };
    float[] numbers = new float[3] {-2 ,0, 2};

    float[] numbersnegative = new float[2] { 0, 2 };
    float[] numbersnzero = new float[2] { -2, 2 };
    float[] numberspositive = new float[2] { -2,0 };
    



    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startwait);
        while (true)
        {
            int randomIndex = Random.Range(0, numbers.Length);
            int hazardIndex = Random.Range(0, hazardnumber.Length);
            hazardcount = hazardnumber[hazardIndex];
            spawnValues.x = numbers[randomIndex];
            for (int i = 0; i < hazardcount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                if ( Mathf.Approximately(spawnValues.x,-2))
                {
                    int randomIndexafter = Random.Range(0, numbersnegative.Length);
                    spawnValues.x = numbersnegative[randomIndexafter];
                }
                else if(Mathf.Approximately(spawnValues.x, 0))
                {
                    int randomIndexmiddle = Random.Range(0, numbersnzero.Length);
                    spawnValues.x = numbersnzero[randomIndexmiddle];
                }
                else if(Mathf.Approximately(spawnValues.x, 2))
                {
                    int randomIndexbefore = Random.Range(0, numberspositive.Length);
                    spawnValues.x = numberspositive[randomIndexbefore];
                }
                 else if (Mathf.Approximately(spawnValues.x, -2) && Mathf.Approximately(spawnValues.x, 0) && hazardcount == 3)//were i need to retsart and resassign variables
                {
                    spawnValues.x = numbersnegative[3];
                }
                else if (Mathf.Approximately(spawnValues.x, -2) && Mathf.Approximately(spawnValues.x, 2) && hazardcount == 3)
                {
         
                    spawnValues.x = numbersnegative[2];
                }
                else if (Mathf.Approximately(spawnValues.x, 0) && Mathf.Approximately(spawnValues.x, 2) && hazardcount == 3)
                {
                   
                    spawnValues.x = numbersnzero[1];
                }
                
                yield return new WaitForSeconds(spawnwait);
            }
            yield return new WaitForSeconds(wavewait);
        }
    }
}
