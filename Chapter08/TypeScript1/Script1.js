// JavaScript source code
function sortByName(arg) {
    var result = arg.slice(0);
    result.sort(function (x, y) {
        return x.name.localCompare(y.name);
    });
    return result;
};
