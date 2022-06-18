$(document).ready(function () {
    console.log("ready")
});

function initCreate() {
    clearForm($('#create-form'));

    Modal.Show({
        title: "Create new customer",
        modalBody: '#modal-create',
        acceptFunction: () => {
            let form = $('#create-form');

            if (!validateFrom(form))
                return

            saveCustomer();
        },
        showCancelButton: true
    })
}

function initEdit(customer) {
    const json = JSON.parse(customer);

    clearForm($('#edit-form'));

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
            let form = $('#edit-form');

            if (!validateFrom(form))
                return

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

    json.CustomerID = !isEdit ? $('#create-form input[name="CustomerID"]').val() : $('#edit-form input[name="CustomerID"]').val();

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

function deleteCustomer(customer) {
    const json = JSON.parse(customer);
    const confirmation = confirm(`¿Está seguro que desea eliminar a ${json.ContactName}?`);

    if (confirmation) {
        $.ajax({
            url: `/Customers/Delete/${json.CustomerID}`,
            method: "DELETE",
            success: function (res) {
                setTimeout(function () {
                    window.location.href = "/Customers";
                }, 300);
            },
            error: function (err) {
                alert("Can't delete. There're orders bound to this customer.");
            }
        })
    }
}

function validateFrom(form) {
    if (form[0].checkValidity() === false) {
        let customerID = form.find('input[name="CustomerID"]');
        let CompanyName = form.find('input[name="CompanyName"]');
        let ContactName = form.find('input[name="ContactName"]');

        if (!customerID.prop('validity').valid) {
            customerID.css('border', '2px solid red');
            customerID.next().text('Required field');
            customerID.next().css('display', 'block');
        }

        if (!CompanyName.prop('validity').valid) {
            CompanyName.css('border', '2px solid red');
            CompanyName.next().text('Required field');
            CompanyName.next().css('display', 'block');
        }

        if (!ContactName.prop('validity').valid) {
            ContactName.css('border', '2px solid red');
            ContactName.next().text('Required field');
            ContactName.next().css('display', 'block');
        }

        return false;
    }

    return true;
}

function clearForm(form) {
    let customerID = form.find('input[name="CustomerID"]');
    let CompanyName = form.find('input[name="CompanyName"]');
    let ContactName = form.find('input[name="ContactName"]');

    $('.customer-form-input').val('');

    customerID.css('border', '1px solid grey');
    customerID.next().css('display', 'none');
    CompanyName.css('border', '1px solid grey');
    CompanyName.next().css('display', 'none');
    ContactName.css('border', '1px solid grey');
    ContactName.next().css('display', 'none');
}