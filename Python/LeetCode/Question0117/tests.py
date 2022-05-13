from node import Node
from solution import Solution

def test_nodes():
    Solution.connect(Solution(), root)
    asserts(root,expectedRoot)

def asserts(node,expectedNode):
    assert node.val == expectedNode.val

    if node.right is not None or expectedNode.right is not None:
        asserts(node.right,expectedNode.right)
        assert node.right.val == expectedNode.right.val

    if node.left is not None or expectedNode.left is not None:
        asserts(node.left,expectedNode.left)
        assert node.left.val == expectedNode.left.val

    if node.next is not None or expectedNode.next is not None:
        assert node.next.val == expectedNode.next.val

node7 = Node(7)
node6 = Node(6)
node5 = Node(5)
node4 = Node(4)
node3 = Node(3,node6,node7)
node2 = Node(2,node4,node5)
root = Node(1,node2,node3)

expectedNode7 = Node(7)
expectedNode6 = Node(6,None,None,expectedNode7)
expectedNode5 = Node(5,None,None,expectedNode6)
expectedNode4 = Node(4,None,None,expectedNode5)
expectedNode3 = Node(3,expectedNode6,expectedNode7)
expectedNode2 = Node(2,expectedNode4,expectedNode5,expectedNode3)
expectedRoot = Node(1,expectedNode2,expectedNode3)

if __name__ == "__main__":
    test_nodes()
    print("Everything passed")