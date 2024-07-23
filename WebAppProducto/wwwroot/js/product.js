function showAlertSweetAlert2(message) {
    Swal.fire(message);
}
function showConfirmAcctionEdit(e,id) {
    e.preventDefault();
    //'Sure you want to delete the record?'
    Swal.fire({
        title: 'Sure you want to edit the record?',
        icon: 'question',
        showCancelButton: true,
        confirmButtonText: 'Yes'
    }).then((resultado) => {
        if (resultado.isConfirmed) {
            window.location.href = `/Product/Edit/${id}`;
        }
    })
}

function showConfirmAcctionDelete(e, id) {
    e.preventDefault();
    //'Sure you want to delete the record?'
    Swal.fire({
        title: 'Sure you want to delete the record?',
        icon: 'question',
        showCancelButton: true,
        confirmButtonText: 'Yes'
    }).then((resultado) => {
        if (resultado.isConfirmed) {
            window.location.href = `/Product/Delete/${id}`;
        }
    })
}





