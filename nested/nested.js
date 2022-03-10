var someObject = {"a":{"b":{"c":"d"}}};

Object.byString = function(o, s) {
s = s.replace(/\[(\w+)\]/g, '.$1'); // convert indexes to properties
s = s.replace(/^\./, ''); // strip a leading dot
var a = s.split('/');
for (var i = 0, n = a.length; i < n; ++i) {
var k = a[i];
if (k in o) {
o = o[k];
} else {
return;
}
}
return o;
}

console.log(Object.byString(someObject, 'a'));
console.log(Object.byString(someObject, 'a/b'));
console.log(Object.byString(someObject, 'a/b/c'));