using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private float startAt;
    private IEnumerator testLoop;

    // Start is called before the first frame update
    void Start()
    {
        startAt = Time.realtimeSinceStartup;
        testLoop = TestLoop();

        StartCoroutine(testLoop);
        //var test = "Test";
        //Debug.Log(test);
        //Debug.Log(test.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator TestLoop()
    {
        while (true)
        {
            var lifeTime = Time.realtimeSinceStartup - startAt;
            Debug.Log("オブジェクトの生存時間（秒）: " + lifeTime);

            if(lifeTime >= 30)
            {
                Debug.Log("TestLoopを停止します。");
                yield break;
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
