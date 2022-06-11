function IngresarCustomerID() {
    let id = prompt('Ingrese id (ej: ALFKI)');
    $('#val').val(id);

    if (id == null || id == "")
        return false;
    else
        return true;
}
