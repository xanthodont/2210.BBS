/**
 * 载入Javascript语言包
 */
document.write('<script src="/Assets/js/lang_zh-CN.js" type="text/javascript"></script>');

var constants = {
	code: {
		success: 1,
		fail: 0
	}
};

// 联系电话(手机/电话皆可)验证 
jQuery.validator.addMethod("isPhone", function (value, element) {
    var length = value.length;
    var mobile = /^(((13[0-9]{1})|(15[0-9]{1}))+\d{8})$/;
    var tel = /^\d{3,4}-?\d{7,9}$/;
    return this.optional(element) || (tel.test(value) || mobile.test(value));

}, "请正确填写您的联系电话");

// 邮政编码验证 
jQuery.validator.addMethod("isZipCode", function (value, element) {
    var tel = /^[0-9]{6}$/;
    return this.optional(element) || (tel.test(value));
}, "请正确填写您的邮政编码");


function developing() {
	alert('开发中……');
}

