const formValidations = {
    errorClass: "form-error",
    rules: {
        CompanyName: {
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
    console.log("ready");

    extendValidator();

    $('#create-form').validate(formValidations);
    $('#edit-form').validate(formValidations);

});

function initCreate() {
    const form = $('#create-form');
    clearForm(form);

    Modal.Show({
        title: "Create new shipper",
        modalBody: '#modal-create',
        acceptFunction: () => {

            if (!form[0].checkValidity() || form.validate().invalidElements().length > 0) {
                form.validate().element(form.find('input[name="CompanyName"]'));
                return
            }
            
            saveShipper();
        },
        showCancelButton: true
    })
}

function initEdit(shipper) {
    const json = JSON.parse(shipper);
    const form = $('#edit-form');

    clearForm(form);

    $('#edit-form input[name="ShipperID"]').val(json.ShipperID);
    $('#edit-form input[name="CompanyName"]').val(json.CompanyName);
    $('#edit-form input[name="Phone"]').val(json.Phone);

    Modal.Show({
        title: "Edit customer",
        modalBody: '#modal-edit',
        acceptFunction: () => {

            if (!form[0].checkValidity() || form.validate().invalidElements().length > 0) {
                form.validate().element(form.find('input[name="CompanyName"]'));
                return
            }

            saveShipper(true);
        },
        showCancelButton: true
    })
}

function saveShipper(isEdit = false) {
    const form = !isEdit ? document.querySelector('#create-form') : document.querySelector('#edit-form');
    const method = !isEdit ? "POST" : "PUT";
    const formData = new FormData(form);
    const json = JSON.parse(JSON.stringify(Object.fromEntries(formData)));
    const url = !isEdit ? "/Shippers/Create" : "/Shippers/Update";

    json.CustomerID = !isEdit ? 0 : $('#edit-form input[name="ShipperID"]').val();

    $.ajax({
        url: url,
        method: method,
        data: json,
        success: function (res) {
            Modal.Close();

            setTimeout(function () {
                window.location.href = "/Shippers";
            }, 300);

        },
        error: function (err) {
            alert(err.responseJSON.message);
            console.log(err);
        }
    })
}

function deleteShipper(shipper) {
    const json = JSON.parse(shipper);
    const confirmation = confirm(`¿Está seguro que desea eliminar a ${json.CompanyName}?`);

    if (confirmation) {
        $.ajax({
            url: `/Shippers/Delete/${json.ShipperID}`,
            method: "DELETE",
            success: function (res) {
                setTimeout(function () {
                    window.location.href = "/Shippers";
                }, 300);
            },
            error: function (err) {
                alert("Can't delete. There're orders bound to this shipper.");
            }
        })
    }
}

function clearForm(form) {
    form[0].reset();
    form.validate().resetForm();
}

function extendValidator() {
    jQuery.validator.addMethod("noSpace", function (value, element) {
        return value.indexOf(" ") < 0 && value != "";
    }, "Don't leave only spaces or spaces at start");
}

