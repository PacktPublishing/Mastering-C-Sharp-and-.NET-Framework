// TypeScript source code
interface Person {
    name: string, 
    age: number
}

function sortByName(arg: Person[]) {
    var result = arg.slice(0);
    result.sort((x, y) => {
        return x.name.localeCompare(y.name);
    });
    return result;
};

