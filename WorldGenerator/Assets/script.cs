using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

Mesh ourMesh;
Vector3[] ourVertices;
Vector3[] ourNormals;
Vector2[] ourUV;
int[] ourTriangles;
public float testNoise;
public float perlinX;
public float perlinY;
private int b;
private int c;

    // Start is called before the first frame update
    void Start()
    {
     ourMesh = GetComponent<MeshFilter>().mesh;
     ourVertices = ourMesh.vertices;
     ourNormals = ourMesh.normals;
     ourUV = ourMesh.uv;
     ourTriangles = ourMesh.triangles;
      //ourTriangles = new int[]{0,8,3};
      b = 5;
      c = 5;

      perlinX = 1;
      perlinY = 1;
   

         
       
    }

   public void AssignMethod(){
         for (var j = 0; j< ourVertices.Length; j++)
        { 
        
        
        
        

        ourVertices[j] = new Vector3(b,Mathf.PerlinNoise(perlinX,perlinY)*Time.deltaTime,c);
       
          perlinX += 1;
          b = b - 1;
          if (b == -6)
          {
         // perlinX = 1;
              b = 5;
              c = c - 1;
          perlinY += 1;
              if (c == -6)
              {
          //perlinY = 1;
                  c = 5;
              }
          } 
      
       //  testNoise = 
        
        }
    }

    // Update is called once per frame
    void Update()
    {
      
       AssignMethod();
      //  Debug.Log(testNoise);
       
          /*
            ourVertices[0] = new Vector3(5,  testNoise,5);
            ourVertices[1] = new Vector3(4,  testNoise,5);
            ourVertices[2] = new Vector3(3,  testNoise,5);
            ourVertices[3] = new Vector3(2,  testNoise,5);
            ourVertices[4] = new Vector3(1,  testNoise,5);
            ourVertices[5] = new Vector3(0,  testNoise,5);
            ourVertices[6] = new Vector3(-1,  testNoise,5);
            ourVertices[7] = new Vector3(-2,  testNoise,5);
            ourVertices[8] = new Vector3(-3,  testNoise,5);
            ourVertices[9] = new Vector3(-4,  testNoise,5);
            ourVertices[10] = new Vector3(-5,  testNoise,5);
            ourVertices[11] = new Vector3(5,testNoise,4);
            ourVertices[12] = new Vector3(4,0,4);
            ourVertices[13] = new Vector3(3,0,4);
            ourVertices[14] = new Vector3(2,0,4);
            ourVertices[15] = new Vector3(1,0,4);
            ourVertices[16] = new Vector3(0,0,4);
            ourVertices[17] = new Vector3(-1,0,4);
            ourVertices[18] = new Vector3(-2,0,4);
            ourVertices[19] = new Vector3(-3,0,4);
            ourVertices[20] = new Vector3(-4,0,4);
            ourVertices[21] = new Vector3(-5,0,4);
            ourVertices[22] = new Vector3(5,0,3);
            ourVertices[23] = new Vector3(4,0,3);
            ourVertices[24] = new Vector3(3,0,3);
            ourVertices[25] = new Vector3(2,0,3);
            ourVertices[26] = new Vector3(1,0,3);
            ourVertices[27] = new Vector3(0,0,3);
            ourVertices[28] = new Vector3(-1,0,3);
            ourVertices[29] = new Vector3(-2,0,3);
            ourVertices[30] = new Vector3(-3,0,3);
            ourVertices[31] = new Vector3(-4,0,3);
            ourVertices[32] = new Vector3(-5,0,3);
            ourVertices[33] = new Vector3(5,0,2);
            ourVertices[34] = new Vector3(4,0,2);
            ourVertices[35] = new Vector3(3,0,2);
            ourVertices[36] = new Vector3(2,0,2);
            ourVertices[37] = new Vector3(1,0,2);
            ourVertices[38] = new Vector3(0,0,2);
            ourVertices[39] = new Vector3(-1,0,2);
            ourVertices[40] = new Vector3(-2,0,2);
            ourVertices[41] = new Vector3(-3,0,2);
            ourVertices[42] = new Vector3(-4,0,2);
            ourVertices[43] = new Vector3(-5,0,2);
            ourVertices[44] = new Vector3(5,0,1);
            ourVertices[45] = new Vector3(4,0,1);
            ourVertices[46] = new Vector3(3,0,1);
            ourVertices[47] = new Vector3(2,0,1);
            ourVertices[48] = new Vector3(1,0,1);
            ourVertices[49] = new Vector3(0,0,1);
            ourVertices[50] = new Vector3(-1,0,1);
            ourVertices[51] = new Vector3(-2,0,1);
            ourVertices[52] = new Vector3(-3,0,1);
            ourVertices[53] = new Vector3(-4,0,1);
            ourVertices[54] = new Vector3(-5,0,1);
            ourVertices[55] = new Vector3(5,0,0);
            ourVertices[56] = new Vector3(4,0,0);
            ourVertices[57] = new Vector3(3,0,0);
            ourVertices[58] = new Vector3(2,0,0);
            ourVertices[59] = new Vector3(1,0,0);
            ourVertices[60] = new Vector3(0,0,0);
            ourVertices[61] = new Vector3(-1,0,0);
            ourVertices[62] = new Vector3(-2,0,0);
            ourVertices[63] = new Vector3(-3,0,0);
            ourVertices[64] = new Vector3(-4,0,0);
            ourVertices[65] = new Vector3(-5,0,0);
            ourVertices[66] = new Vector3(5,0,-1);
            ourVertices[67] = new Vector3(4,0,-1);
            ourVertices[68] = new Vector3(3,0,-1);
            ourVertices[69] = new Vector3(2,0,-1);
            ourVertices[70] = new Vector3(1,0,-1);
            ourVertices[71] = new Vector3(0,0,-1);
            ourVertices[72] = new Vector3(-1,0,-1);
            ourVertices[73] = new Vector3(-2,0,-1);
            ourVertices[74] = new Vector3(-3,0,-1);
            ourVertices[75] = new Vector3(-4,0,-1);
            ourVertices[76] = new Vector3(-5,0,-1);
            ourVertices[77] = new Vector3(5,0,-2);
            ourVertices[78] = new Vector3(4,0,-2);
            ourVertices[79] = new Vector3(3,0,-2);
            ourVertices[80] = new Vector3(2,0,-2);
            ourVertices[81] = new Vector3(1,0,-2);
            ourVertices[82] = new Vector3(0,0,-2);
            ourVertices[83] = new Vector3(-1,0,-2);
            ourVertices[84] = new Vector3(-2,0,-2);
            ourVertices[85] = new Vector3(-3,0,-2);
            ourVertices[86] = new Vector3(-4,0,-2);
            ourVertices[87] = new Vector3(-5,0,-2);
            ourVertices[88] = new Vector3(5,0,-3);
            ourVertices[89] = new Vector3(4,0,-3);
            ourVertices[90] = new Vector3(3,0,-3);
            ourVertices[91] = new Vector3(2,0,-3);
            ourVertices[92] = new Vector3(1,0,-3);
            ourVertices[93] = new Vector3(0,0,-3);
            ourVertices[94] = new Vector3(-1,0,-3);
            ourVertices[95] = new Vector3(-2,0,-3);
            ourVertices[96] = new Vector3(-3,0,-3);
            ourVertices[97] = new Vector3(-4,0,-3);
            ourVertices[98] = new Vector3(-5,0,-3);
            ourVertices[99] = new Vector3(5,0,-4);
            ourVertices[100] = new Vector3(4,0,-4);
            ourVertices[101] = new Vector3(3,0,-4);
            ourVertices[102] = new Vector3(2,0,-4);
            ourVertices[103] = new Vector3(1,0,-4);
            ourVertices[104] = new Vector3(0,0,-4);
            ourVertices[105] = new Vector3(-1,0,-4);
            ourVertices[106] = new Vector3(-2,0,-4);
            ourVertices[107] = new Vector3(-3,0,-4);
            ourVertices[108] = new Vector3(-4,0,-4);
            ourVertices[109] = new Vector3(-5,0,-4);
            ourVertices[110] = new Vector3(5,0,-5);
            ourVertices[111] = new Vector3(4,0,-5);
            ourVertices[112] = new Vector3(3,0,-5);
            ourVertices[113] = new Vector3(2,0,-5);
            ourVertices[114] = new Vector3(1,0,-5);
            ourVertices[115] = new Vector3(0,0,-5);
            ourVertices[116] = new Vector3(-1,0,-5);
            ourVertices[117] = new Vector3(-2,0,-5);
            ourVertices[118] = new Vector3(-3,0,-5);
            ourVertices[119] = new Vector3(-4,0,-5);
            ourVertices[120] = new Vector3(-5,0,-5);
            
        
                 Debug.Log("vertices number : "+j+" Vertices value : "+ourVertices[j]);
        Debug.Log(b);
           

     
         
            */
            
           // ourVertices[j] = new Vector3( Random.Range(-50.0f, 50.0f), Random.Range(-50.0f, 50.0f), Random.Range(-50.0f, 50.0f));
     

        for (var i = 0; i< ourNormals.Length; i++)
        {
          //   Debug.Log("normals number : "+i+" normals value : "+ourNormals[i]);
         //  ourNormals[i] += Vector3.forward * Time.deltaTime;
           //ourNormals[1] += Vector3.up * Time.deltaTime;
           //ourNormals[2] += Vector3.right * Time.deltaTime;
        }


        for (var y = 0; y< ourUV.Length; y++)
        {
           //  Debug.Log("UV number : "+y+" UV value : "+ourUV[y]);
          // ourUV[y] += Vector2.down * Time.deltaTime;
           //ourUV[1] += Vector3.up * Time.deltaTime;
           //ourUV[2] += Vector3.right * Time.deltaTime;
        }

        for (var h = 0; h< ourTriangles.Length; h++)
        {
          //  Debug.Log("Triangles number :"+h+"Triangles value : "+ourTriangles[h]);
           

        }

       

         ourMesh.vertices = ourVertices;
         ourMesh.normals = ourNormals;
         ourMesh.uv = ourUV;
         ourMesh.triangles = ourTriangles;

         ourMesh.RecalculateBounds();
         ourMesh.RecalculateNormals();

       
    }
}
