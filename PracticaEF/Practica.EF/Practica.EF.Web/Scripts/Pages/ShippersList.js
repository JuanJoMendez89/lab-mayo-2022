$(document).ready(function () {
    console.log("ready")
});

function initCreate() {
    clearForm($('#create-form'));

    Modal.Show({
        title: "Create new shipper",
        modalBody: '#modal-create',
        acceptFunction: () => {
            let form = $('#create-form');

            if (!validateFrom(form))
                return

            saveShipper();
        },
        showCancelButton: true
    })
}

function initEdit(shipper) {
    const json = JSON.parse(shipper);

    clearForm($('#edit-form'));

    $('#edit-form input[name="ShipperID"]').val(json.ShipperID);
    $('#edit-form input[name="CompanyName"]').val(json.CompanyName);
    $('#edit-form input[name="Phone"]').val(json.Phone);

    Modal.Show({
        title: "Edit customer",
        modalBody: '#modal-edit',
        acceptFunction: () => {
            let form = $('#edit-form');

            if (!validateFrom(form))
                return

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

function validateFrom(form) {
    if (form[0].checkValidity() === false) {
        let CompanyName = form.find('input[name="CompanyName"]');

        if (!CompanyName.prop('validity').valid) {
            CompanyName.css('border', '2px solid red');
            CompanyName.next().text('Required field');
            CompanyName.next().css('display', 'block');
        }

        return false;
    }

    return true;
}

function clearForm(form) {
    let CompanyName = form.find('input[name="CompanyName"]');

    $('.customer-form-input').val('');

    CompanyName.css('border', '1px solid grey');
    CompanyName.next().css('display', 'none');

}