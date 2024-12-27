
//主要放置一些共用變數
interface ExportComponent {
    symbol: string,
    content: VueComponent
}

/*
 * 這是用來跟C#介接轉資料送到VUE裡面用的
 須設定 v-on:init 來指定初始資料要傳遞給誰
 exp:<view-data  data="" v-on:init="initData"></view-data>
不設置or decode="true"  表示需要解碼  decode="false" 不須解碼
 */
let viewData: ExportComponent = {
    symbol: 'view-data',
    content: {
        props: ['data', 'decode'],
        /*    emits: ['init'],*/
        watch: {

        },
        template: ``,//這邊會跳警告 但不用管 依樣可以用

        created() {

            //console.log(`view data create decode->${this.decode} decode type->${typeof this.decode}`);

            let isDecode = this.decode == undefined ? true : this.decode == 'true';

            //console.log(`view data isDecode->${isDecode} `)

            var items = isDecode ? JSON.parse(base64.decode(this.data)) : JSON.parse(this.data)
            //console.log(`view data get->${JSON.stringify(items)}`)
            this.$emit('init', items)
        }
    }
}




var exports = {
    vue_component: [
        viewData
    ]
};

enum ApiResponse {
    Json = "json",
    Text = "text"
}

type  ApiBack<T> = { success: (res: T) => void, error: (err: any) => void }
class CallApi {
    public static SetLang = new CallApi('/Admin/main/set_language');
    public static DoLogin = new CallApi('/Admin/main/DoLogin');
    

    private path: string = '';
    private dataType: string;    

    private constructor(p: string, t: string = 'json') {
        this.path = p;
        this.dataType = t;
    }

    public static link(path: string, t: ApiResponse = ApiResponse.Json): CallApi {
        return new CallApi(path, t.toString());
    }


    public post<T = any>(data: any, back: ApiBack<T>, ext: any = {}) {
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
        $.ajax(this.path, config)        
    }
    public get<T = any>(data: any , back: ApiBack<T>, ext: any = {}) {
        let config = {
            type: "get",
            data: data,
            dataType: this.dataType,
            async: false,
            success: back.success,
            error: back.error
        }
        //屬性複寫或延展
        config= $.extend({}, config, ext)

        $.ajax(this.path, config)
    }
}


class EventBus {
    //公用實體
    public static entity = new EventBus();

    // 收集订阅信息,调度中心
    public eventList = {};
    // 下面的都是自定义值
    public msg = '';
    private constructor() {

    }
    //建立新實體
    public static creat(): EventBus { return new EventBus(); }

    // 訂閱
    $on(name, fn) {
        this.eventList[name] = this.eventList[name] || []
        this.eventList[name].push(fn)
    }

    // 發布
    $emit(name, data=null) {
        if (this.eventList[name]) {
            this.eventList[name].forEach((fn) => {
                fn(data)
            });
        }
    }

    // 取消订阅
    $off(name) {
        if (this.eventList[name]) {
            delete this.eventList[name]
        }
    }
}

class App {
    public static initVue(i: BaseVueController) {
        let a = Vue.createApp(i)

        exports.vue_component.forEach(item => {
            //console.log(`vue component->${JSON.stringify(item)}`)
            a.component(item.symbol, item.content)
        })

        a.mount(i.el)
    }

    private constructor() { }
}

/**
需使用 ~/assets/js/loading.js
 */
class Progress {
    public static create(select: string = 'body') { return new Progress(select); }

    private pro: any
    private constructor(select: string) {
        this.pro = ($(select) as any).initLoad({
            type: 2,
        });

    }
    public show() {
        this.pro.show()
    }
    public hide() {
        this.pro.hide()
    }
}