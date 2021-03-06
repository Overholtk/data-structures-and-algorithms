using System;
using System.Collections.Generic;
using Xunit;

namespace Trees
{
    public class UnitTest1
    {
        [Fact]
        public void Instantiate_Empty_Tree()
        {
            BinaryTree tree = new BinaryTree();
            Assert.Null(tree.Root);
        }

        [Fact]
        public void Instantiate_Tree_With_Root()
        {
            BinarySearchTree tree = new BinarySearchTree();
            BinarySearchTree.Add(null, 7, tree);
            Assert.Equal(7, tree.Root.Value);
            
        }

        [Fact]
        public void Add_Right_Node()
        {
            BinarySearchTree tree = new BinarySearchTree();
            BinarySearchTree.Add(null, 7, tree);
            BinarySearchTree.Add(tree.Root, 4, tree);
            BinarySearchTree.Add(tree.Root, 14, tree);
            Assert.NotNull(tree.Root.Right);
        }

        [Fact]
        public void Add_Left_Node()
        {
            BinarySearchTree tree = new BinarySearchTree();
            BinarySearchTree.Add(null, 7, tree);
            BinarySearchTree.Add(tree.Root, 4, tree);
            BinarySearchTree.Add(tree.Root, 14, tree);
            Assert.NotNull(tree.Root.Left);
        }

        [Fact]
        public void Get_PreOrder_Collection()
        {
            BinaryTree tree = new BinarySearchTree();
            BinarySearchTree.Add(null, 7, tree);
            BinarySearchTree.Add(tree.Root, 4, tree);
            BinarySearchTree.Add(tree.Root, 14, tree);
            List<int> values = new List<int>();
            List<int> testList = new List<int>();
            testList.Add(7);
            testList.Add(4);
            testList.Add(14);
            Assert.Equal(testList, BinaryTree.PreOrder(tree.Root, values));
        }

        [Fact]
        public void Get_InOrder_Collection()
        {
            BinaryTree tree = new BinarySearchTree();
            BinarySearchTree.Add(null, 7, tree);
            BinarySearchTree.Add(tree.Root, 4, tree);
            BinarySearchTree.Add(tree.Root, 14, tree);
            List<int> values = new List<int>();
            List<int> testList = new List<int>();
            testList.Add(4);
            testList.Add(7);
            testList.Add(14);
            Assert.Equal(testList, BinaryTree.InOrder(tree.Root, values));
        }

        [Fact]
        public void Get_PostOrder_Collection()
        {
            BinaryTree tree = new BinarySearchTree();
            BinarySearchTree.Add(null, 7, tree);
            BinarySearchTree.Add(tree.Root, 4, tree);
            BinarySearchTree.Add(tree.Root, 14, tree);
            List<int> values = new List<int>();
            List<int> testList = new List<int>();
            testList.Add(4);
            testList.Add(14);
            testList.Add(7);
            Assert.Equal(testList, BinaryTree.PostOrder(tree.Root, values));
        }

        [Fact]
        public void Get_Breadth_Values()
        {
            BinaryTree tree = new BinaryTree();
            BinarySearchTree.Add(null, 12, tree);
            BinarySearchTree.Add(tree.Root, 5, tree);
            BinarySearchTree.Add(tree.Root, 16, tree);
            BinarySearchTree.Add(tree.Root, 8, tree);
            //values added to list in order expected to be outputted
            List<int> valuesList = new List<int>();
            valuesList.Add(12);
            valuesList.Add(5);
            valuesList.Add(8);
            valuesList.Add(16);
            List<int> values = new List<int>();
            Assert.Equal(valuesList, BinaryTree.BreadthFirst(tree.Root, values, tree));
        }

        [Fact]
        public void Breadth_Values_Fail()
        {
            BinaryTree tree = new BinaryTree();
            BinarySearchTree.Add(null, 12, tree);
            BinarySearchTree.Add(tree.Root, 5, tree);
            BinarySearchTree.Add(tree.Root, 16, tree);
            BinarySearchTree.Add(tree.Root, 8, tree);
            //values added to list in same order inputted
            List<int> valuesList = new List<int>();
            valuesList.Add(12);
            valuesList.Add(5);
            valuesList.Add(16);
            valuesList.Add(8);
            List<int> values = new List<int>();
            Assert.NotEqual(valuesList, BinaryTree.BreadthFirst(tree.Root, values, tree));
        }
    }
}
