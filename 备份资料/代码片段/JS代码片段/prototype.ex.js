/***************************************************************************
*
* Macrowing Pharm GMP Quality Management System
* http://www.macrowing.com
*
* Copyright (c) Macrowing Pharm Technology Co.,Ltd
* All Rights Reserved.
*
* Technical Support: Pharm R&D Team
* Creator: xueyi.wang 2022/4/7 10:49:39
*
***************************************************************************/

//字符串-左补全长度
String.prototype.padStart = function (targetLength, padString) {
    let string = this;
    while (string.length < targetLength) {
        string = padString + string;
    }
    return string;
}
//字符串-右补全长度
String.prototype.padEnd = function (targetLength, padString) {
    let string = this;
    while (string.length < targetLength) {
        string = string + padString;
    }
    return string;
}

//日期-格式化
Date.prototype.format = function (format) {
    let ret;
    let date = this;
    const optArray = {
        // 有其他格式化字符需求可以继续添加，必须转化成字符串
        "y+": date.getFullYear().toString(),                                            // 年
        "M+": (date.getMonth() + 1).toString(),                                         // 月
        "d+": date.getDate().toString(),                                                // 日
        "h+": ((date.getHours() / 12) > 1 ? date.getHours() - 12 : date.getHours()).toString(),   // 时-12
        "H+": date.getHours().toString(),                                               // 时-24
        "m+": date.getMinutes().toString(),                                             // 分
        "s+": date.getSeconds().toString(),                                             // 秒
        "S+": date.getMilliseconds().toString(),                                        // 毫秒
        "f+": date.getMilliseconds().toString(),                                        // 毫秒
        "q+": Math.floor((date.getMonth() + 3) / 3).toString(),                         // 季度
        "u+": parseInt(new Date().valueOf()).toString(),                                //0时区时间戳-毫秒
        "U+": parseInt(new Date().valueOf() / 1000).toString()                            //0时区时间戳-秒
    };
    for (let k in optArray) {
        ret = new RegExp("(" + k + ")").exec(format);
        if (ret) {
            let tempStr = ret[1].length == 1
                ? optArray[k]
                : optArray[k].padStart(ret[1].length, "0");

            format = format.replace(ret[1], tempStr);
        };
    };
    return format;
}

//日期-相加
window.addDate = function (interval, number, date) {
    if (date == null)
        return "";

    date = new Date(date);
    let dateFs = date.valueOf();

    switch (interval) {
        case "day":
            dateFs += number * 24 * 60 * 60 * 1000;
            break;
        case "hour":
            dateFs += number * 60 * 60 * 1000;
            break;
        case "minute":
            dateFs += number * 60 * 1000;
            break;
        case "second":
            dateFs += number * 1000;
            break;
        case "millisecond":
            dateFs += number;
            break;

        default:
            return "";
    }
    return new Date(dateFs);
}

//日期-加天
Date.prototype.addDay = function (number) {
    let date = this;
    return window.addDate("day", number, date);
}

//日期-加小时
Date.prototype.addHour = function (number) {
    let date = this;
    return window.addDate("hour", number, date);
}

//日期-加分钟
Date.prototype.addMinute = function (number) {
    let date = this;
    return window.addDate("minute", number, date);
}

//日期-加秒
Date.prototype.addSecond = function (number) {
    let date = this;
    return window.addDate("second", number, date);
}

//日期-加毫秒
Date.prototype.addMillisecond = function (number) {
    let date = this;
    return window.addDate("millisecond", number, date);
}

//数组- FirstOrDefault
Array.prototype.firstOrDefault = function (predicate) {
    let sourceArray = this;

    for (var i = 0; i < sourceArray.length; i++) {
        let judgeResult = predicate(sourceArray[i]);

        if (judgeResult) {
            return sourceArray[i];
        }
    }
}
