const Modal = {
    Show: function (info) {
        let modal = document.querySelector('#mymodal-back');
        let body =  document.querySelector(info.modalBody);

        if (modal === null) {
            this.Create(info.acceptFunction, info.showCancelButton);
        }

        document.querySelector('.mymodal-header p').textContent = info.title

        if (body !== null) document.querySelector('#mymodal-back .mymodal-body').appendChild(body);

        document.querySelector('#mymodal-back').classList.remove('bg-out');
        document.querySelector('#mymodal-back .mymodal-container').classList.remove('container-out');

        document.querySelector('#mymodal-back').classList.add('bg-in');
        document.querySelector('#mymodal-back .mymodal-container').classList.add('container-in');
    },
    Create: function (acceptFunction, showCancelButton) {
        let back = document.createElement('div');
        let container = document.createElement('div');
        let header = document.createElement('div');
        let headerTitle = document.createElement('p');
        let body = document.createElement('div');
        let footer = document.createElement('div');
        let accept = document.createElement('button');
        let cancel = document.createElement('button');


        back.setAttribute('id', 'mymodal-back');
        container.className = "mymodal-container";
        header.className = "mymodal-header";
        body.className = "mymodal-body";
        footer.className = "mymodal-footer";

        accept.className = "btn btn-primary mymodal-button";
        cancel.className = "btn btn-primary mymodal-button";

        accept.textContent = "Aceptar";
        cancel.textContent = "Cancelar";

        accept.onclick = acceptFunction;

        if (showCancelButton) {
            footer.appendChild(cancel);
        }

        footer.appendChild(accept);

        header.appendChild(headerTitle);

        container.appendChild(header);
        container.appendChild(body);
        container.appendChild(footer);

        back.appendChild(container);

        document.querySelector('body').appendChild(back);
    },
    Cancel: function () {
        this.Close();
    },
    Close: function () {
        document.querySelector('#mymodal-back').classList.remove('bg-in');
        document.querySelector('#mymodal-back .mymodal-container').classList.remove('container-in');

        document.querySelector('#mymodal-back').classList.add('bg-out');
        document.querySelector('#mymodal-back .mymodal-container').classList.add('container-out');
    }
}