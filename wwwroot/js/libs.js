class BaseVueController {
    constructor() {
        this.el = '#app';
        this.components = {};
        this.filters = {};
        this.watch = {};
        this.computed = {};
        this.methods = {};
        this.data = function () {
        };
        this.setup = function () { };
        this.mounted = function () {
        };
        this.created = function () {
        };
    }
}
/**
 * 以下是擴展方法
 *(先declare才能正常擴展)
 */
//interface String {
//    jsonParse<T>(): T
//}
//String.prototype.jsonParse = function<T>():T {
//    return JSON.parse(this) as T;
//}
Object.defineProperty(Object.prototype, 'jsonString', {
    value() {
        return JSON.stringify(this);
    }
});
Object.defineProperty(String.prototype, 'jsonParse', {
    value() {
        return JSON.parse(this);
    }
});
Object.defineProperty(Array.prototype, 'first', {
    value(fun) {
        if (fun) {
            return this.find(fun);
        }
        return this.find(e => true); // or this.find(Boolean)
    }
});
String.prototype.isEmpty = function () {
    return (!this || this == undefined || this == "" || this.length == 0);
};
Array.prototype.remove = function (value) {
    var index = this.indexOf(value);
    if (index > -1) {
        this.splice(index, 1);
    }
};
Array.prototype.removeAll = function (value) {
    var i = 0;
    while (i < this.length) {
        if (this[i] === value) {
            this.splice(i, 1);
        }
        else {
            ++i;
        }
    }
};
Array.prototype.includes = function (value) {
    return this.indexOf(value) > -1;
};
Array.prototype.addRange = function (list) {
    list.forEach(a => this.push(a));
};
function jsonString(s) {
    return s.jsonString();
}
function jsonParse(a) {
    return a.jsonParse();
}
function _try(value, defaultValue) {
    try {
        return (value === null || value === undefined) ? defaultValue : value;
    }
    catch (e) {
        return defaultValue;
    }
}
//<-- 擴展函式結束 -->
//# sourceMappingURL=libs.js.map