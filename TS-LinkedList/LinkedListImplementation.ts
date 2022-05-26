class NodeCL{
    value:string
    next:NodeCL
    constructor(val:string){
        this.value= val;
        this.next = null;
    }
}


// const nodeA = new NodeCL("A");
// const nodeB = new NodeCL("B");
// const nodeC = new NodeCL("C");
// const nodeD = new NodeCL("D");
// nodeA.next = nodeB;
// nodeB.next = nodeC;
// nodeC.next = nodeD;
// nodeD.next = null;

// const PrintLinkedList=(head)=>{
//     let currrent = head;
//     while(currrent !=null){
//         console.log(currrent.val);
//         currrent = currrent.next;
//     }

// }

// PrintLinkedList(nodeA);