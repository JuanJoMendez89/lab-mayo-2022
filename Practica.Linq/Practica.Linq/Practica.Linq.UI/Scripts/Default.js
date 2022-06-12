function IngresarCustomerID() {
    let id = prompt('Ingrese id', 'ALFKI');
    $('#val').val(id);

    if (id == null || id == "")
        return false;
    else
        return true;
}
