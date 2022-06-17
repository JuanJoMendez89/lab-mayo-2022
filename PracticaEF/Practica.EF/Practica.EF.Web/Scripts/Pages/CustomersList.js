$(document).ready(function () {
    console.log("ready")
});

function addCustomer() {
    console.log("add customer")

    //$.ajax({
    //    url: "/Customers/Create",
    //    method: "GET",
    //    success: function (res) {
    //        console.log(res);
    //    },
    //    error: function (err) {
    //        console.log(err);
    //    }
    //})

    Modal.Show({
        title: "Prueba",
        modalBody: '#test',
        acceptFunction: () => {
            Modal.Close();
        },
        showCancelButton: false
    })
}