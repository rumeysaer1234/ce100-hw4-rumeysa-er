/**
* @file ce100-hw4-algo-lib-cs
* @author Rümeysa Er
* @date 16 May 2022
*
* @brief <b> HW-4 Functions </b>
*
* HW-4 Sample Lib Functions
*
* @see http://bilgisayar.mmf.erdogan.edu.tr/en/
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ce100_hw4_algo_lib_cs;

namespace ce100_hw4_algo_lib_cs
{
    public class Class1
    {
        public class ActivitySelection
        {

            /* ***************
            *
            *	  @name   printMaxActivities (Print Activity Selection Problem)
            *
            *	  @brief Print Activity Selection Problem
            *
            *	  Print Activity Selection Problem
            *
            *	  @param  [in] s [\b int]  s
            *	  
            *	  @param  [in] f [\b int]  f
            *	  
            *	  @param  [in] n [\b int]  n
            *	  
            *	  We have:
            *     A set of activities with fixed start and finish times
            *     One shared resource (only one activity can use at any time)
            *     Objective: Choose the max number of compatible activities
            *     Note: Objective is to maximize the number of activities, not the total time of activities.
 
            *     Example:
            
            *     Activities: Meetings with fixed start and finish times
            *     Shared resource: A meeting room
            *     Objective: Schedule the max number of meetings
            *	  
            * **************
            **/



            public static int printMaxActivities(int[] s, int[] f, int n)
            {
                int i, j;


                i = 0;

                for (j = 1; j < n; j++)
                {
                 
                    if (s[j] >= f[i])
                    {
                        i = j;
                    }
                }

                return i;
            }

        }




        /**
        * ***************
        * 
        * @name knapSack
        * @param [in] arr [\b int[]] 
        * @param [in] low [\b int] 
        * @param [in] high [\b int]
        * Given weights and values of n items, put these items in a knapsack of capacity W to get the maximum total value in the knapsack.
        * In other words, given two integer arrays val and wt which represent values and weights associated with n items respectively. 
        * Also given an integer W which represents knapsack capacity, find out the maximum value subset of val
        *  such that sum of the weights of this subset is smaller than or equal to W.
        * You cannot break an item, either pick the complete item or don’t pick it (0-1 property).
        * Build table K in bottom up manner

        * ***************
        **/
        public static int knapSack(int A, int[] wt,
                          int[] val, int b)
        {
            int c, x;
            int[,] K = new int[b + 1, A + 1];

         
            for (c = 0; c <= b; c++)
            {
                for (x = 0; x <= A; x++)
                {
                    if (c == 0 || x == 0)
                        K[c, x] = 0;

                    else if (wt[c - 1] <= x)
                        K[c, x] = Math.Max(
                            val[c - 1]
                            + K[c - 1, x - wt[c - 1]],
                            K[c - 1, x]);
                    else
                        K[c, x] = K[c - 1, x];
                }
            }

            return K[b, A];
        }

        /**
        * ***************
        * 
        * @name printknapSack
        * @param [in] arr [\b string[]] 
        * @param [in] low [\b string] 
        * @param [in] high [\b string]
        * Given weights and values of n items, put these items in a knapsack of capacity W to get the maximum total value in the knapsack.
        * In other words, given two integer arrays, val and wt represent values and weights associated with n items respectively.
        * Also given an integer W which represents knapsack capacity,
        * find out the items such that sum of the weights of those items of a given subset is smaller than or equal to W.
        * You cannot break an item, either pick the complete item or don’t pick it 
        * 
        * Build table K in bottom up manner
        * res equal stores the result of Knapsack
        * either the result comes from the top
        *  or from 
        * as in Knapsack table. If
        * it comes from the latter one it means
        * the item is included.
        * Since this weight is included its
        * value is deducted
        * 
        * ***************
        **/

        public static string printknapSack(int W, int[] wt,
                                 int[] val, int n)
        {
            int i, w;
            string print = "";
            int[,] K = new int[n + 1, W + 1];

           
            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (wt[i - 1] <= w)
                        K[i, w] = Math.Max(val[i - 1] +
                                K[i - 1, w - wt[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }
            
            int res = K[n, W];



            w = W;
            for (i = n; i > 0 && res > 0; i--)
            {

              
                if (res == K[i - 1, w])
                    continue;
                else
                {

                   
                    print += wt[i - 1] + ", ";

                   
                    res = res - val[i - 1];
                    w = w - wt[i - 1];
                }
            }
            return print.Remove(print.Length - 2);
        }


        /**
        * ***************
        * 
        * @name Graphbfs
        * @param [in] arr [\b int[]] 
        * @param [in] low [\b int] 
        * @param [in] high [\b int]
        * Breadth First Traversal for a graph is similar to Breadth First Traversal of a tree (See method 2 of this post).
        * The only catch here is, unlike trees, graphs may contain cycles, 
        * so we may come to the same node again. To avoid processing a node more than once,
        * we use a boolean visited array.
        * For simplicity, it is assumed that all vertices are reachable from the starting vertex. 
        * 
        * AddEdgebfs equal Function to add an edge into the graph
        * Prints BFS traversal from a given source s
        * 
        * Get all adjacent vertices of the
        * dequeued vertex s. If a adjacent
        * has not been visited, then mark it
        * visited and enqueue it
        * ***************
        **/

        public static int _V;

        public static LinkedList<int>[] _adj;

        public static void Graphbfs(int V)
        {
            _adj = new LinkedList<int>[V];
            for (int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
            _V = V;
        }

        public static void AddEdgebfs(int v, int w)
        {
            _adj[v].AddLast(w);

        }

        public static string BFS(int s)
        {
            string bfs = "";
            
           
            bool[] visited = new bool[_V];
            for (int i = 0; i < _V; i++)
                visited[i] = false;

          
            LinkedList<int> queue = new LinkedList<int>();

            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any())
            {

    
                s = queue.First();
                bfs += s + ", ";
                queue.RemoveFirst();

                LinkedList<int> list = _adj[s];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
            return bfs.Remove(bfs.Length - 2);
        }



        /**
        * 
        * ***************
        * 
        * @name DFS
        * @param [in] arr [\b int[]] 
        * @param [in] low [\b int] 
        * @param [in] high [\b int]
        * Depth first search is an algorithm for traversing or searching tree or graph data structures.
        * The algorithm starts at the root node (selecting some arbitrary node as the root node 
        * in the case of a graph) and explores as far as possible along each branch before backtracking.
        * So the basic idea is to start from the root or any arbitrary node and mark the node and move to the adjacent 
        * unmarked node and continue this loop until there is no unmarked adjacent node.
        * Then backtrack and check for other unmarked nodes and traverse them. Finally, print the nodes in the path.
        * 
        * ***************
        **/

        public static List<int>[] Adj;
        public static void Graphdfs(int v)
        {
            V = v;
            Adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                Adj[i] = new List<int>();
        }

        public static void AddEdgedfs(int v, int w)
        {
            Adj[v].Add(w); 
        }

        public static string dfs = ""; 
        
        public static void dfsUtil(int v, bool[] visited)
        {
           
            visited[v] = true;
            dfs += v + ", ";

           
            List<int> vList = Adj[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                    dfsUtil(n, visited);
            }
        }

        public static string DFS(int v)
        {
            bool[] visited = new bool[V];

            dfsUtil(v, visited);
            return dfs.Remove(dfs.Length - 2);
        }

        /**
      * ***************
      * 
      * @name Topological Order
      * @param [in] arr [\b int[]] 
      * @param [in] low [\b int] 
      * @param [in] high [\b int]
      * Topological sorting for Directed Acyclic Graph (DAG) is a linear ordering of
      * vertices such that for every directed edge u v, vertex u comes before v in the ordering.
      * Topological Sorting for a graph is not possible if the graph is not a DAG.
      * 
      * ***************
      **/



        public static int V;
      
        public static List<List<int>> adj;
     
        public static void Graph_Tpl(int v)
        {
            V = v;
            adj = new List<List<int>>(v);
            for (int i = 0; i < v; i++)
                adj.Add(new List<int>());
        }

      
        public static void AddEdge_Tpl(int v, int w) { adj[v].Add(w); }

    
        public static void TopologicalOrderUtil(int v, bool[] visited, Stack<int> stack)
        {

           
            visited[v] = true;

           
            foreach (var vertex in adj[v])
            {
                if (!visited[vertex])
                    TopologicalOrderUtil(vertex, visited, stack);
            }

           
            stack.Push(v);
        }

        public static string TopologicalOrder()
        {
            Stack<int> stack = new Stack<int>();
            string tpl = "";

         
            var visited = new bool[V];

            
            for (int i = 0; i < V; i++)
            {
                if (visited[i] == false)
                    TopologicalOrderUtil(i, visited, stack);
            }

           
            foreach (var vertex in stack)
            {
                tpl += vertex + ", ";
            }
            return tpl.Remove(tpl.Length - 2);
        }



    }

    /*
    *  ***************
    *
    *	  @name   SCCProblem (SCC Function)
    *
    *	  @brief SCC Function
    *
    *	  SCC Function
    *
    *	  @param  [in] v [\b int]  v
    *	  
    *     SCC Algorithm is used to find the connected components in a graph.
    *     A directed graph is strongly connected if there is a path between all pairs of vertices. 
    *     A strongly connected component (SCC) of a directed graph is a maximal strongly connected subgraph. 
    *     
    *  ***************
    **/

    public class SCCProblem
    {
        private int V;
        private LinkedList<int>[] adj;
        private int Time;
        public void addEdge(int v, int w)
        {
            adj[v].AddLast(w);
        }

        public SCCProblem(int v)
        {
            V = v;
            adj = new LinkedList<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }
        public void SCCUtil(int u, int[] low, int[] disc, bool[] stackMember, Stack<int> stack)
        {
            low[u] = disc[u] = Time++;
            stack.Push(u);
            stackMember[u] = true;
            foreach (int v in adj[u])
            {
                if (disc[v] == -1)
                {
                    SCCUtil(v, low, disc, stackMember, stack);
                    low[u] = Math.Min(low[u], low[v]);
                }
                else if (stackMember[v])
                {
                    low[u] = Math.Min(low[u], disc[v]);
                }
            }
            if (low[u] == disc[u])
            {
                int v;
                do
                {
                    v = stack.Pop();
                    stackMember[v] = false;
                } while (v != u);
            }
        }
        public int SCC()
        {
            int[] low = new int[V];
            int[] disc = new int[V];
            bool[] stackMember = new bool[V];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < V; i++)
            {
                disc[i] = -1;
                low[i] = -1;
            }
            for (int i = 0; i < V; i++)
            {
                if (disc[i] == -1)
                {
                    SCCUtil(i, low, disc, stackMember, stack);
                }
            }
            return 0;
        }
    }
}

    

