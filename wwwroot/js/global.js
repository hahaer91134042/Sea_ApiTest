/*
 * 這是用來跟C#介接轉資料送到VUE裡面用的
 須設定 v-on:init 來指定初始資料要傳遞給誰
 exp:<view-data  data="" v-on:init="initData"></view-data>
不設置or decode="true"  表示需要解碼  decode="false" 不須解碼
 */
let viewData = {
    symbol: 'view-data',
    content: {
        props: ['data', 'decode'],
        /*    emits: ['init'],*/
        watch: {},
        template: ``,
        created() {
            //console.log(`view data create decode->${this.decode} decode type->${typeof this.decode}`);
            let isDecode = this.decode == undefined ? true : this.decode == 'true';
            //console.log(`view data isDecode->${isDecode} `)
            var items = isDecode ? JSON.parse(base64.decode(this.data)) : JSON.parse(this.data);
            //console.log(`view data get->${JSON.stringify(items)}`)
            this.$emit('init', items);
        }
    }
};
var exports = {
    vue_component: [
        viewData
    ]
};
var ApiResponse;
(function (ApiResponse) {
    ApiResponse["Json"] = "json";
    ApiResponse["Text"] = "text";
})(ApiResponse || (ApiResponse = {}));
class CallApi {
    constructor(p, t = 'json') {
        this.path = '';
        this.path = p;
        this.dataType = t;
    }
    static link(path, t = ApiResponse.Json) {
        return new CallApi(path, t.toString());
    }
    post(data, back, ext = {}) {
        let config = {
            type: "post",
            data: data,
            dataType: this.dataType,
            async: false,
            success: back.success,
            error: back.error
        };
        //屬性複寫或延展
        config = $.extend({}, config, ext);
        //console.log(`post config->${JSON.stringify(config)}`)
        $.ajax(this.path, config);
    }
    get(data, back, ext = {}) {
        let config = {
            type: "get",
            data: data,
            dataType: this.dataType,
            async: false,
            success: back.success,
            error: back.error
        };
        //屬性複寫或延展
        config = $.extend({}, config, ext);
        $.ajax(this.path, config);
    }
}
CallApi.SetLang = new CallApi('/Admin/main/set_language');
CallApi.DoLogin = new CallApi('/Admin/main/DoLogin');
class EventBus {
    constructor() {
        // 收集订阅信息,调度中心
        this.eventList = {};
        // 下面的都是自定义值
        this.msg = '';
    }
    //建立新實體
    static creat() { return new EventBus(); }
    // 訂閱
    $on(name, fn) {
        this.eventList[name] = this.eventList[name] || [];
        this.eventList[name].push(fn);
    }
    // 發布
    $emit(name, data = null) {
        if (this.eventList[name]) {
            this.eventList[name].forEach((fn) => {
                fn(data);
            });
        }
    }
    // 取消订阅
    $off(name) {
        if (this.eventList[name]) {
            delete this.eventList[name];
        }
    }
}
//公用實體
EventBus.entity = new EventBus();
class App {
    static initVue(i) {
        let a = Vue.createApp(i);
        exports.vue_component.forEach(item => {
            //console.log(`vue component->${JSON.stringify(item)}`)
            a.component(item.symbol, item.content);
        });
        a.mount(i.el);
    }
    constructor() { }
}
/**
需使用 ~/assets/js/loading.js
 */
class Progress {
    static create(select = 'body') { return new Progress(select); }
    constructor(select) {
        this.pro = $(select).initLoad({
            type: 2,
        });
    }
    show() {
        this.pro.show();
    }
    hide() {
        this.pro.hide();
    }
}
//# sourceMappingURL=global.js.map