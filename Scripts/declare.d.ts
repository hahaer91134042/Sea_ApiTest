
/**
需使用base64.js
 */
declare const base64: Base64Static;

interface Base64Static {
    decode(d: any): string
}

/**
vue3  操作符
 */
declare const Vue: VueStatic;


interface VueStatic {
    createApp(v: any): any;
    ref<T = any>(o: T, s?: string): VueRef<T>;
    reactive(o: any): any;
    computed(i: ()=>any): any;
    watch<T>(v: VueRef<T>, back: (now: T, old: T) => void, option?: WatchOption);
    //nextTick 是将回调推迟到下一个 DOM 更新周期之后执行。在更改了一些数据以等待 DOM 更新后立即使用它
    nextTick(b: Function);
}

interface VueRef<T> {
    value: T
}
interface WatchOption {
    deep: boolean
}




//----擴展方法----
declare interface JQuery<TElement> extends DataSource {
    datetimepicker(arg0?: { format: string; minView?: number; autoclose?: boolean; }): any;//bootstrap-datetimepicker.js
    datetimepicker(key: string, value: string): any;//bootstrap-datetimepicker.js
    bootstrapSwitch(): unknown;//bootstrap-switch.js
}


declare interface Data {
    //接口允许有任意的属性
    [propName: string]: any
    jsonString: () => string;
}

declare interface DataSource {
    jsonParse<T>(): T
}


declare interface Array<T> extends Data {
    first(fn?: (a: T) => boolean): T
    remove(a: T)
    removeAll(a: T)
    includes(e: T): boolean
    addRange(a: Array<T>)
}
declare interface String extends DataSource {
    isEmpty(): boolean
}
//declare interface Object extends DataSource {
//    //接口允许有任意的属性
//    [propName: string]: any
//}