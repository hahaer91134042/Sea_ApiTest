$(function () {
    let main = {
        el: "#app",
        methods: {},
        data() {
        },
        setup() {
            //fetch("/home/LoadFile?name=ApiLog2023-10-27.txt", { method:"Get" })
            //    .then(response => {
            //        if (response.ok) {
            //            //console.log(`header content-disposition ->${JSON.stringify(response)}`)
            //            return response.text();
            //        }
            //    }).then(txt => {
            //        console.log(`txt->${txt}`)
            //    })
            let fileNames = Vue.ref([]);
            let selectName = Vue.ref("");
            let logLine = Vue.ref([]);
            let searchLog = Vue.ref("");
            let searchFile = Vue.ref("");
            let logMsg = Vue.computed(() => {
                if (searchLog.value.length < 1)
                    return logLine.value;
                return _.filter(logLine.value, t => t.toLowerCase().indexOf(searchLog.value.toLowerCase()) > -1);
            });
            //Vue.watch(searchLog, (now, old) => {
            //    logLine.value = _.filter(logLine.value, t=>t.indexOf(now)>-1)
            //});
            let logFiles = Vue.computed(() => {
                if (searchFile.value.length < 1)
                    return fileNames.value;
                return _.filter(fileNames.value, t => t.toLowerCase().indexOf(searchFile.value.toLocaleLowerCase()) > -1);
            });
            Vue.watch(selectName, function (now, old) {
                console.log(`selectName new->${now}`);
                CallApi.link(`/home/LoadFile?name=${now}`, ApiResponse.Text)
                    .get({}, {
                    success: function (res) {
                        console.log(`CallApi txt->${res}`);
                        logLine.value = [];
                        res.split(/[\n]/).forEach(txt => {
                            if (txt.length > 0)
                                logLine.value.push(txt);
                        });
                        console.log(`log line->${JSON.stringify(logLine.value)} `);
                        logLine.value = _.orderBy(logLine.value, t => t, 'desc');
                    },
                    error: function (err) {
                    }
                });
            });
            CallApi.link("/home/LogFileName")
                .get({}, {
                success: function (res) {
                    console.log(`Call Api LogFileName->${JSON.stringify(res)}`);
                    res.forEach(n => fileNames.value.push(n));
                },
                error: function (err) {
                }
            });
            return {
                logFiles,
                selectName,
                logMsg,
                searchLog,
                searchFile,
                onSelectName(name) {
                    //console.log(`on select name->${name}`);
                    selectName.value = name;
                }
            };
        },
        created() {
            console.log(`---log init---`);
        }
    };
    App.initVue(main);
});
//# sourceMappingURL=Log.js.map