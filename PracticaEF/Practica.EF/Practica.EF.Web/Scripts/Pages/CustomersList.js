$(document).ready(function () {
    console.log("ready")
});

function initCreate() {
    Modal.Show({
        title: "Create new customer",
        modalBody: '#modal-create',
        acceptFunction: () => {
            saveCustomer();
        },
        showCancelButton: false
    })
}

function initEdit(customer) {
    const json = JSON.parse(customer);

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

    json.CustomerID = $('#edit-form input[name="CustomerID"]').val();

    $.ajax({
        url: "/Customers/Update",
        method: "PUT",
        data: json,
        success: function (res) {
            alert("customer updated");
            Modal.Close();
        },
        error: function (err) {
            console.log(err);
        }
    })
}