using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
namespace unity
{
    public class DoubleLinkedList
    {
        //节点类Node
        private class Node
        {
            public Object value;
            public Node prev;
            public Node next;

            public Node(Object v)
            {
                value = v;
                prev = this;
                next = this;
            }

            public string toString()
            {
                return value.ToString();
            }

            private Node head = new Node(null);
            private int size;                       //大小

            #region 接口方法
            //MARKER Interface Func
            //添加到最前
            public bool AddFirst(Object o)
            {
                AddAfter(new Node(0), head);
                return true;
            }
            //添加到最后
            public bool AddLast(Object o)
            {
                AddBefore(new Node(0), head);
                return true;
            }

            //直接添加
            public bool Add(Object o)
            {
                return AddLast(o);
            }
            //添加到指定位置
            public bool Add(int index, Object o)
            {
                AddBefore(new Node(o), GetNode(index));
                return true;
            }
            //移除制定位置
            public bool Remove(int index)
            {
                RemoveNode(GetNode(index));
                return true;
            }
            //移除最前
            public bool RemoveFirst()
            {
                RemoveNode(head.next);
                return true;
            }
            //移除最后
            public bool RemoveLast()
            {
                RemoveNode(head.prev);
                return true;
            }
            //返回指定位置元素
            public Object Get(int index)
            {
                return GetNode(index).value;
            }

            public int Size()
            {
                return size;
            }

            public override String ToString()
            {
                StringBuilder s = new StringBuilder("[");
                Node node = head;
                for (int i = 0; i < size; i++)
                {
                    node = node.next;
                    if (i > 0)
                        s.Append(", ");
                    s.Append(node.value);
                }
                s.Append("]");
                return s.ToString();
            }
            #endregion

            #region 具体实现
            //MARKER Concrete realization
            private Node GetNode(int index)
            {
                if (index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                Node node = head.next;
                for (int i = 0; i < index; i++)
                {
                    node = node.next;
                }
                return node;
            }

            private void AddBefore(Node newNode, Node node)
            {
                newNode.next = node;
                newNode.prev = node.prev;
                newNode.next.prev = newNode;
                newNode.prev.next = newNode;
                size++;
            }

            private void AddAfter(Node newNode, Node node)
            {
                newNode.prev = node;
                newNode.next = node.next;
                newNode.next.prev = newNode;
                newNode.prev.next = newNode;
                size++;
            }

            private void RemoveNode(Node node)
            {
                node.prev.next = node.next;
                node.next.prev = node.prev;
                node.prev = null;
                node.next = null;
                size--;
            }
            #endregion
        }

    }

}
