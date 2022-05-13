from node import Node

class Solution(object):
    def connect(self, root):
        self.populateNext(0, {}, root)

    def populateNext(self, depth, dict, node):
        if node is None:
            return

        if dict.get(depth) is None:
            dict[depth] = node
        else:
            node.next = dict[depth]
            dict[depth] = node

        if node.right is not None:
            self.populateNext(depth+1, dict, node.right)
        if node.left is not None:
            self.populateNext(depth+1, dict, node.left)
