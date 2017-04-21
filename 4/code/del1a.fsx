let one = [|-1; 9; -1 |]
let two = [|-1; 16; -1|]
let three = [|-1; 24; -1|]
let four = [|-1; 36; -1|]

type  DoublyLinkedListUtil  = class
    static member insert (L : int[,]) (x : int[]) = 
        printf "%s" "herp"
end

type DoublyLinkedList = class
    member head : int = -1 ///maybe make this 
    member tail : int = -1
end


let dli = Array2D.zeroCreateBased 0 0 10  3
DoublyLinkedListUtil.insert dli one

///dli.[0,0] <- one.[0]
///dli.[0,1] <- one.[1]
///dli.[0,2] <- one.[2]

///x should have a X.next, which is basically just X.[2], X.[0] is previous and X.[1] is the value
    

(*
      static member create (x : int) = 
            doublyLinkedList = []
            element = []
            element[0] = -1
            element[1] = x
            element[2] = -1
            doublyLinkedList[0] = element
            return doublyLinkedList
*)

let F (S, z) = 
    x = S.head;
    isFinished = false;
    while(isFinished) {
        if(x == null) 
            S.tail.next = z
            z.previous = S.tail
            S.tail = z
            isFinished = true 
        else if(x <= z) 
            z.next = x.next
            z.next.previous = z
            x.next = z
            z.previous = x
            isFinished = true
        else //x.next > 0
            x = x.next
    }


