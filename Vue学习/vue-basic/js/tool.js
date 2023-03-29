//排序-升序
Array.prototype.orderBy = function (propFunc) {
    if (!propFunc) {
        return this.slice();
    }
    else {
        return this.slice()
            .sort((a, b) => propFunc(a) - propFunc(b));
    }
};

//排序-降序
Array.prototype.orderByDesc = function (propFunc) {
    if (!propFunc) {
        return this.slice();
    }
    else {
        return this.slice().sort((a, b) => propFunc(b) - propFunc(a));
    }
};
