/*****************
* 프로그램명 : TileManager_Winter.cs

* 작성자 : 김성수 ( 천은정, 권순규, 유병주, 전승원 )

* 작성일 : 2019년 12월 7일

* 프로그램 설명 : winter맵의 맵이 끈기지 않도록 계속 생성하여 붙여준다.

***********************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager_Winter : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 0.0f; //길이 시작하는 z좌표
    private float tileLength = 120.0f; //타일 하나의 길이
    private int amnTilesOnScreen = 1; //?? (화면에표시할타일수..?)


    // Start is called before the first frame update
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; //캐릭터 위치 추적
        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
        }

    }

    // Update is called once per frame
    private void Update()
    {
        if (playerTransform.position.z+50 > (spawnZ - amnTilesOnScreen * tileLength)) //새로운 타일 생성
        {
            SpawnTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
    }

}
