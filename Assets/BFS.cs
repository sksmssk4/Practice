using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BFS : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[][] graph =new int[1000][];
        int[] bfs = new int[1000];
        int[] queue = new int[1000];
	}
	
    void BFS(int v, int n)
    {
        int front = 0;
        int rear = 0;
        int pop, i;

        Debug.Log(v);
        queue[0] = v;
        rear++;
        bfs[v] = i;

        while(front<rear)
        {
            pop = queue[front];
            front++;

            for(i=1; i<n; i++)
            {
                if(graph(pop)[i]==1 && bfs[i]==0)
                {
                    Debug.Log(i);
                    queue[rear] = i;
                    rear++;
                    bfs[i] = 1;
                }
            }
        }
        retrun;
    }
	// Update is called once per frame
	void Update () {
        int x, y;
        BFS(x,y);
        graph[x][y] = 1;
        graph[y][x] = 1;

        bfs(0, 1);
        return 0;

	}
}
