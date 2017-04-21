var x = {
    this.left = null;
    this.right = null;
};


var B = {
    this.left = null;
    this.right = null;
}

var C = {
    this.left = null;
    this.right = null;
}

var D = {
    this.left = null;
    this.right = null;
}

var E = {
    this.left = null;
    this.right = null;
}

var F = {
    this.left = null;
    this.right = null;
}

var G = {
    this.left = null;
    this.right = null;
}

var H = {
    this.left = null;
    this.right = null;
}

var A = {
    this.left = B;
    this.right = C;
}

function shortestPathToLeaf(x) {
    if(x == null) {

    
    }
    if(left[x] == null & right[x] == null) {
        return 1;
    } 
    return Math.min(shortestPathToLeaf(x.left), shortestPathToLeaf(x.right))
}
