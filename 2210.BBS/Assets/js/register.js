var Register = function () {
    return {
        //main function to initiate the module
        init: function () {
            var form = $('#js-register-form');
            var error = $('.alert-error', form);
            var success = $('.alert-success', form);
            form.validate({
                errorElement: 'lable', //default input error message container
	            errorClass: 'help-inline', // default input error message class
	            focusInvalid: false, // do not focus the last invalid input
	            rules: {
	                username: {
	                    required: true,
	                    minlength: 6,
                        maxlength: 20
	                },
	                nickname: {
	                    required: true,
	                    minlength: 3,
	                    maxlength: 20
	                },
	                realname: {
	                    required: true,
	                    minlength: 3,
	                    maxlength: 20
	                },
	                password: {
	                    required: true,
	                    minlength: 10,
	                    maxlength: 20
	                },
	                eqpassword: {
	                    required: true,
	                    minlength: 10,
	                    maxlength: 20,
                        equalTo: '#password'
	                },
	                padq: {
	                    minlength: 6,
	                    maxlength: 20
	                },
	                pada: {
	                    minlength: 6,
	                    maxlength: 20
	                },
	                phone: {
	                    isPhone: true
	                },
	                email: {
                        email: true
	                },
	                zipcode: {
	                    isZipCode: true
	                }
	            },

	            messages: {
	                username: {
	                    required: '请输入用户名'
	                },
	                password: {
	                    required: '请输入密码'
	                }
	            },

	            errorPlacement: function (error, element) {
	                error.insertAfter(element); // for other inputs, just perform default behavoir
	            },

	            invalidHandler: function (event, validator) { //display error alert on form submit   
	                success.hide();
	                error.show();
	                App.scrollTo(error, -200);
	            },
	            success: function (label) {
	                if (label.attr("for") == "service" || label.attr("for") == "roleId") { // for checkboxes and radip buttons, no need to show OK icon
	                    label.closest('.control-group').removeClass('error').addClass('success');
	                    label.remove(); // remove error label here
	                } else { // display success icon for other inputs
	                    label.addClass('valid').addClass('help-inline ok') // mark the current input as valid and display OK icon
                        .closest('.control-group').removeClass('error').addClass('success'); // set success class to the control group
	                }
	            },
	            highlight: function (element) { // hightlight error inputs
	                $(element)
                        .closest('.help-inline').removeClass('ok'); // display OK icon
	                $(element)
                        .closest('.control-group').removeClass('success').addClass('error'); // set error class to the control group
	            },

	            submitHandler: function (form) {
	                form.submit();
	            }
	        });

	        

	        if (jQuery().datepicker) {
	            $('.date-picker').datepicker();
	        }

            
        }

    };

}();