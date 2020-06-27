const callbackKeyName = 'callback';

const SchemaJs = {

    callbacks: {},

    callbackCount: 0,

    callbackFuncToString: function (func) {
        if (!func || func === '') {
            return;
        }
        let funcObj;
        if (typeof func === 'string') { // func string name
            funcObj = top[func];
        } else if (typeof func === "function") {
            funcObj = func;
        }
        let callbackPropName = 'cb_func_' + (this.callbackCount++);
        this.callbacks[callbackPropName] = funcObj;
        return 'SchemaJs["callbacks"]["' + callbackPropName + '"]';
    },

    extend: function (a, b) {
        for (let prop in a) {
            if (b.hasOwnProperty(prop)) {
                if (prop === callbackKeyName) {
                    a[prop] = this.callbackFuncToString(b[prop]);
                } else {
                    a[prop] = b[prop];
                }
            }
        }
        return a;
    },

    invoke: function (options) {
        let defaultOpts = {
            schemaName: '',
            data: {},
            callback: '',
            beforeInvoke: function (eventArgs) {

            }
        };
        let opts = this.extend(defaultOpts, options);
        if (!opts.schemaName || opts.schemaName === '') {
            throw new Error('schemaName should not be EMPTY!');
        }

        let finalUrl = customUrlFormat(opts.schemaName, opts.data, opts.callback);
        if (opts.beforeInvoke) {
            let eventArgs = {finalUrl: finalUrl, cancel: false};
            opts.beforeInvoke(eventArgs);
            if (eventArgs.cancel) {
                return;
            }
        }

        function invokeByFrame(url) {
            let iFrame = document.createElement('iframe');
            iFrame.src = url;
            iFrame = null;
        }

        invokeByFrame(finalUrl);
    }
}

const schemeName = 'MyCustomScheme';
const protocolSeparator = '://';
const host = '';
const schemaKeyName = 'schema';

const customUrlFormat = function (schemaName, data, callback) {
    let arr = [];
    for (let paramName in data) {
        if (!data.hasOwnProperty(paramName)) {
            continue;
        }
        arr.push({name: paramName, value: data[paramName]});
    }
    arr.unshift({name: schemaKeyName, value: schemaName}); // put it to first
    arr.push({name: callbackKeyName, value: callback});
    let query = arr.map(item => item.name + '=' + item.value).join('&');
    return schemeName + protocolSeparator + host + '/?' + query;
}