

class BaseVueController {
    //接口允许有任意的属性
    [propName: string]: any

    el = '#app'
    components?= {}
    filters?= {}
    watch?= {}
    computed?= {}

    methods = {}

    data = function () {

    }

    setup? = function () { }


    mounted?= function () {
        
    }

    created = function () {

    }

}

interface VueComponent {
    props: Array<string>;
    watch: object;
    template: string;
    data?: Function;
    methods?: object;
    setup?: Function;
    created: Function;
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
        return JSON.stringify(this)
    }
})
Object.defineProperty(String.prototype, 'jsonParse', {
    value() {
        return JSON.parse(this)
    }
})
Object.defineProperty(Array.prototype, 'first', {
    value(fun) {
        if (fun) {
            return this.find(fun)
        }
        return this.find(e => true)     // or this.find(Boolean)
    }
})
String.prototype.isEmpty = function (): boolean {
    return (!this || this == undefined || this == "" || this.length == 0);
}
Array.prototype.remove = function (value) {
    var index = this.indexOf(value);
    if (index > -1) {
        this.splice(index, 1);
    }
}
Array.prototype.removeAll = function (value) {
    var i = 0;
    while (i < this.length) {
        if (this[i] === value) {
            this.splice(i, 1);
        } else {
            ++i;
        }
    }
}
Array.prototype.includes = function (value): boolean {
    return this.indexOf(value) > -1
}
Array.prototype.addRange = function <T>(list: Array<T>) {
    list.forEach(a => this.push(a))    
}

function jsonString(s): string {
    return s.jsonString()
}
function jsonParse<T>(a): T {
    return a.jsonParse() as T
}
function _try(value, defaultValue) {
    try {
        return (value === null || value === undefined) ? defaultValue : value;
    } catch (e) {
        return defaultValue;
    }
}
//<-- 擴展函式結束 -->