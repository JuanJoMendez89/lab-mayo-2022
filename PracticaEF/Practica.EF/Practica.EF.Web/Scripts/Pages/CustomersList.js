const formValidations = {
    errorClass: "form-error",
    rules: {
        CustomerID: {
            required: true,
            noSpace: true,
            minLength: true
        },
        CompanyName: {
            required: true,
            noSpace: true
        },
        ContactName: {
            required: true,
            noSpace: true
        },
    },
    highlight: function (element) {
        $(element).closest('.control-group').removeClass('success').addClass('error');
    },
    success: function (element) {
        element.text('').addClass('valid')
            .closest('.control-group').removeClass('error').addClass('success');
    }
};

$(document).ready(function () {
    console.log("ready")

    extendValidator();

    $('#create-form').validate(formValidations);
    $('#edit-form').validate(formValidations);

    $('.form-anchor').on('click', function (e) {
        e.preventDefault();
    });
});

function initCreate() {
    const form = $('#create-form');
    clearForm(form);

    Modal.Show({
        title: "Create new customer",
        modalBody: '#modal-create',
        acceptFunction: () => {



            //if (!form[0].checkValidity() || form[0].validate().invalidElements().length > 0) {
            if (!form.valid()) {
                form.validate().element(form.find('input[name="CustomerID"]'));
                form.validate().element(form.find('input[name="CompanyName"]'));
                form.validate().element(form.find('input[name="ContactName"]'));
                return
            }

            saveCustomer();
        },
        showCancelButton: true
    })
}

function initEdit(customer) {
    const json = JSON.parse(customer);
    const form = $('#edit-form');

    clearForm(form);

    $('#edit-form input[name="CustomerID"]').val(json.CustomerID);
    $('#edit-form input[name="CompanyName"]').val(json.CompanyName);
    $('#edit-form input[name="ContactName"]').val(json.ContactName);
    $('#edit-form input[name="ContactTitle"]').val(json.ContactTitle);
    $('#edit-form input[name="Address"]').val(json.Address);
    $('#edit-form input[name="City"]').val(json.City);
    $('#edit-form input[name="Region"]').val(json.Region);
    $('#edit-form input[name="PostalCode"]').val(json.PostalCode);
    $('#edit-form input[name="Country"]').val(json.Country);
    $('#edit-form input[name="Phone"]').val(json.Phone);
    $('#edit-form input[name="Fax"]').val(json.Fax);

    Modal.Show({
        title: "Edit customer",
        modalBody: '#modal-edit',
        acceptFunction: () => {

            if (!form[0].checkValidity() || form.validate().invalidElements().length > 0) {
                form.validate().element(form.find('input[name="CustomerID"]'));
                form.validate().element(form.find('input[name="CompanyName"]'));
                form.validate().element(form.find('input[name="ContactName"]'));
                return
            }

            saveCustomer(true);
        },
        showCancelButton: true
    })
}

function saveCustomer(isEdit = false) {
    const form = !isEdit ? document.querySelector('#create-form') : document.querySelector('#edit-form');
    const method = !isEdit ? "POST" : "PUT";
    const formData = new FormData(form);
    const json = JSON.parse(JSON.stringify(Object.fromEntries(formData)));
    const url = !isEdit ? "/Customers/Create" : "/Customers/Update";

    $.ajax({
        url: url,
        method: method,
        data: json,
        success: function (res) {
            Modal.Close();

            setTimeout(function () {
                window.location.href = "/Customers";
            }, 300);
            
        },
        error: function (err) {
            alert(err.responseJSON.message);
            console.log(err);
        }
    })
}

function clearForm(form) {
    form[0].reset();
    form.validate().resetForm();
}

function extendValidator() {
    jQuery.validator.addMethod("noSpace", function (value, element) {
        if (value[0] == " " || value.trim().length < 1)
            return false
        else
            return true
    }, "Don't leave only spaces or spaces at start");

    jQuery.validator.addMethod("minLength", function (value, element) {
        if (value.trim().length !=  5)
            return false
        else
            return true
    }, "Minimun length must be 5");
}