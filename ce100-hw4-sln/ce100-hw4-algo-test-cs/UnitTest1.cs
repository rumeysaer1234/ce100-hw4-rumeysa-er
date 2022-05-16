using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw4_algo_lib_cs;
using static ce100_hw4_algo_lib_cs.Class1;


namespace ce100_hw4_algo_test_cs
{
    [TestClass]
    public class UnitTest1

    {

        //ACTIVITYSELECTIONTEST1***

        [TestMethod]
        public void activity_selection_test_1()
        {
            int[] s = { 1, 3, 0, 5, 8, 5 };

            int[] f = { 2, 4, 6, 7, 9, 9 };
            int n = s.Length;

            int act = ActivitySelection.printMaxActivities(s, f, n);
            int res = 4;
            Assert.AreEqual(act, res);
        }

        //ACTIVITYSELECTIONTEST2***

        [TestMethod]
        public void activity_selection_test_2()
        {
            int[] s = { 47, 453, 123, 78635, 1, 85 };

            int[] f = { 47, 64513, 2123, 789, 23, 12 };
            int n = s.Length;

            int act = ActivitySelection.printMaxActivities(s, f, n);
            int res = 3;
            Assert.AreEqual(act, res);
        }

        //ACTIVITYSELECTIONTEST2***

        [TestMethod]
        public void activity_selection_test_3()
        {
            int[] s = { 653, 65, 645, 879, 132, 653 };

            int[] f = { 89465, 6513, 5367, 147, 51, 54 };
            int n = s.Length;

            int act = ActivitySelection.printMaxActivities(s, f, n);
            int res = 0;
            Assert.AreEqual(act, res);
        }



        //KNAPSACKTEST1***

        [TestMethod]
        public void knapsacktest_1()
        {
            int[] val = new int[] { 80, 200, 250 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 20;
            int n = val.Length;
            int result = Class1.knapSack(W, wt, val, n);
            int expected = 200;
            Assert.AreEqual(expected, result);
        }
        
        //KNAPSACKTEST2***

        [TestMethod]
        public void knapsacktest_2()
        {
            int[] val = new int[] { 70, 220, 300 };
            int[] wt = new int[] { 20, 30, 50 };
            int W = 50;
            int n = val.Length;
            int result = Class1.knapSack(W, wt, val, n);
            int expected = 300;
            Assert.AreEqual(expected, result);
        }

        //KNAPSACKTEST3***

        [TestMethod]
        public void knapsacktest_3()
        {
            int[] val = new int[] { 90, 160, 280 };
            int[] wt = new int[] { 30, 40, 70 };
            int W = 70;
            int n = val.Length;
            int result = Class1.knapSack(W, wt, val, n);
            int expected = 280;
            Assert.AreEqual(expected, result);
        }

        //PRINTKNAPSACKTEST1***

        [TestMethod]
        public void printknapSacktest_1()
        {
            int[] val = { 60, 100, 120 };
            int[] wt = { 10, 20, 30 };
            int W = 50;
            int n = val.Length;
            string result = Class1.printknapSack(W, wt, val, n);
            string expected = "30, 20";
            Assert.AreEqual(expected, result);

            
        }

        //PRINTKNAPSACKTEST2***

        [TestMethod]
        public void printknapSacktest_2()
        {
            int[] val = { 60, 100, 120 };
            int[] wt = { 10, 20, 30 };
            int W = 50;
            int n = val.Length;
            string result = Class1.printknapSack(W, wt, val, n);
            string expected = "30, 20";
            Assert.AreEqual(expected, result);


        }

        //PRINTKNAPSACKTEST3***

        [TestMethod]
        public void printknapSacktest_3()
        {
            int[] val = { 60, 100, 120 };
            int[] wt = { 10, 20, 30 };
            int W = 50;
            int n = val.Length;
            string result = Class1.printknapSack(W, wt, val, n);
            string expected = "30, 20";
            Assert.AreEqual(expected, result);


        }

        //BFSTEST1***

        [TestMethod]
        public void BFS_Test1()
        {
            Class1.Graphbfs(4);

            Class1.AddEdgebfs(0, 1);
            Class1.AddEdgebfs(0, 2);
            Class1.AddEdgebfs(1, 2);
            Class1.AddEdgebfs(2, 0);
            Class1.AddEdgebfs(2, 3);
            Class1.AddEdgebfs(3, 3);

            string result = Class1.BFS(2);
            string expected = "2, 0, 3, 1";
            Assert.AreEqual(result, expected);
        }

        //BFSTEST2***

        [TestMethod]
        public void BFS_Test2()
        {
            Class1.Graphbfs(3);

            Class1.AddEdgebfs(0, 1);
            Class1.AddEdgebfs(0, 2);
            string result = Class1.BFS(0);
            string expected = "0, 1, 2";
            Assert.AreEqual(result, expected);
        }

        //BFSTEST3***

        [TestMethod]
        public void BFS_Test3()
        {
            Class1.Graphbfs(5);

            Class1.AddEdgebfs(0, 1);
            Class1.AddEdgebfs(0, 2);
            Class1.AddEdgebfs(0, 3);
            Class1.AddEdgebfs(2, 4);

            string result = Class1.BFS(0);
            string expected = "0, 1, 2, 3, 4";
            Assert.AreEqual(result, expected);
        }

        //DFSTEST1***

        [TestMethod]
        public void DFS_Test1()
        {
            Class1.Graphdfs(4);

            Class1.AddEdgedfs(0, 1);
            Class1.AddEdgedfs(0, 2);
            Class1.AddEdgedfs(1, 2);
            Class1.AddEdgedfs(2, 0);
            Class1.AddEdgedfs(2, 3);
            Class1.AddEdgedfs(3, 3);
            Class1.dfs = "";
            string result = Class1.DFS(2);
            string expected = "2, 0, 1, 3";
            Assert.AreEqual(result, expected);
        }

        //DFSTEST2***

        [TestMethod]
        public void DFS_Test2()
        {
            Class1.Graphdfs(4);

            Class1.AddEdgedfs(0, 1);
            Class1.AddEdgedfs(0, 3);
            Class1.AddEdgedfs(1, 2);
            Class1.AddEdgedfs(2, 1);
            Class1.AddEdgedfs(3, 0);
            Class1.AddEdgedfs(3, 3);
            Class1.dfs = "";
            string result = Class1.DFS(0);
            string expected = "0, 1, 2, 3";
            Assert.AreEqual(result, expected);
        }

        //DFSTEST3***

        [TestMethod]
        public void DFS_Test3()
        {
            Class1.Graphdfs(5);

            Class1.AddEdgedfs(0, 1);
            Class1.AddEdgedfs(0, 2);
            Class1.AddEdgedfs(0, 4);
            Class1.AddEdgedfs(1, 0);
            Class1.AddEdgedfs(2, 0);
            Class1.AddEdgedfs(3, 4);
            Class1.AddEdgedfs(4, 0);
            Class1.AddEdgedfs(4, 3);
            Class1.dfs = "";
            string result = Class1.DFS(0);
            string expected = "0, 1, 2, 4, 3";
            Assert.AreEqual(result, expected);
        }

        //TOPOLOGICALORDERTEST1***

        [TestMethod]
        public void TopologicalOrder_Test1()
        {
            Class1.Graph_Tpl(6);

            Class1.AddEdge_Tpl(5, 2);
            Class1.AddEdge_Tpl(5, 0);
            Class1.AddEdge_Tpl(4, 0);
            Class1.AddEdge_Tpl(4, 1);
            Class1.AddEdge_Tpl(2, 3);
            Class1.AddEdge_Tpl(3, 1);

            string result = Class1.TopologicalOrder();
            string expected = "5, 4, 2, 3, 1, 0";
            Assert.AreEqual(result, expected);
        }

        //TOPOLOGICALORDERTEST2***

        [TestMethod]
        public void TopologicalOrder_Test2()
        {
            Class1.Graph_Tpl(6);

            Class1.AddEdge_Tpl(0, 1);
            Class1.AddEdge_Tpl(0, 2);
            Class1.AddEdge_Tpl(1, 3);
            Class1.AddEdge_Tpl(1, 4);
            Class1.AddEdge_Tpl(3, 4);
            Class1.AddEdge_Tpl(3, 5);

            string result = Class1.TopologicalOrder();
            string expected = "0, 2, 1, 3, 5, 4";
            Assert.AreEqual(result, expected);
        }

        //TOPOLOGICALORDERTEST3***

        [TestMethod]
        public void TopologicalOrder_Test3()
        {
            Class1.Graph_Tpl(5);

            Class1.AddEdge_Tpl(0, 1);
            Class1.AddEdge_Tpl(0, 3);
            Class1.AddEdge_Tpl(1, 2);
            Class1.AddEdge_Tpl(2, 3);
            Class1.AddEdge_Tpl(2, 4);
            Class1.AddEdge_Tpl(3, 4);

            string result = Class1.TopologicalOrder();
            string expected = "0, 1, 2, 3, 4";
            Assert.AreEqual(result, expected);
        }


        //SCCTEST1***

        [TestMethod]
        public void SCC_test_1()
        {
            SCCProblem g = new SCCProblem(4);
            g.addEdge(0, 1);
            g.addEdge(1, 2);
            g.addEdge(2, 3);
            int result = g.SCC();
            SCCProblem g1 = new SCCProblem(4);
            g1.addEdge(0, 1);
            g1.addEdge(1, 2);
            g1.addEdge(2, 3);
            int expected = g1.SCC();
            Assert.AreEqual(expected, result);
            }

        //SCCTEST2***

        [TestMethod]
        public void SCC_test_2()
        {
            SCCProblem g = new SCCProblem(4);
            g.addEdge(0, 1);
            g.addEdge(1, 2);
            g.addEdge(2, 3);
            int result = g.SCC();
            SCCProblem g1 = new SCCProblem(4);
            g1.addEdge(0, 1);
            g1.addEdge(1, 2);
            g1.addEdge(2, 3);
            int expected = g1.SCC();
            Assert.AreEqual(expected, result);
            }

         //SCCTEST3***

        [TestMethod]
        public void SCC_test_3()
        {
            SCCProblem g = new SCCProblem(4);
            g.addEdge(0, 1);
            g.addEdge(1, 2);
            g.addEdge(2, 3);
            int result = g.SCC();
            SCCProblem g1 = new SCCProblem(4);
            g1.addEdge(0, 1);
            g1.addEdge(1, 2);
            g1.addEdge(2, 3);
            int expected = g1.SCC();
             Assert.AreEqual(expected, result);
            }
        }
    }









