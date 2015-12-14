function primeFinderFactory(){
    var cache = {};
    function isPrime(n){
        console.log('processing - ', n);
        if (n <= 3) return true;
        for(var i=2; i<=(n/2); i++)
            if (n % i === 0) return false;
        return true;
    }
    function primeFinder(n){
        if (typeof cache[n] === 'undefined')
            cache[n] = isPrime(n);
        return cache[n];
    }
    return primeFinder;
}

function squareRootFactory(){
    var cache = {};
    function sqrt(n){
        console.log('processing - ', n);
        return Math.sqrt(n)
    }
    return function(n){
        if (typeof cache[n] === 'undefined')
            cache[n] = isPrime(n);
        return cache[n];
    }
}


function cacheFactory(fn){
    var cache = {};
    return function(n){
        var key = JSON.stringify(arguments);
        if (typeof cache[key] === 'undefined')
            cache[key] = fn.apply(this,arguments);
        return cache[key];
    }
}
