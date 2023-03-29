//排序-升序
Array.prototype.orderBy = function (propFunc) {
    return this.sort((a, b) => {
        const propA = propFunc(a);
        const propB = propFunc(b);

        if (propA < propB) {
            return -1;
        } else if (propA > propB) {
            return 1;
        }
        else {
            return 0;
        }

    });
};

//排序-降序
Array.prototype.orderByDesc = function (propFunc) {
    return this.sort((a, b) => {
        const propA = propFunc(a);
        const propB = propFunc(b);

        if (propA < propB) {
            return 1;
        } else if (propA > propB) {
            return -1;
        }
        else {
            return 0;
        }

    });
};
