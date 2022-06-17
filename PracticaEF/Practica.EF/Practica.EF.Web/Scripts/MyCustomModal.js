const Modal = {
    NodeParent: null,
    isModalOn: false,
    Show: function (info) {
        let modal = document.querySelector('#mymodal-back');
        let body = document.querySelector(info.modalBody);

        if (this.isModalOn) return;

        if (modal === null) {
            this.Create(info.acceptFunction, info.showCancelButton);
        } else {
            this.RenderButtons(info.acceptFunction, info.showCancelButton);
        }

        document.querySelector('.mymodal-header p').textContent = info.title

        if (body !== null) {
            this.NodeParent = body.parentNode
            document.querySelector('#mymodal-back .mymodal-body').appendChild(body);
        }

        document.querySelector('#mymodal-back').classList.remove('bg-out');
        document.querySelector('#mymodal-back .mymodal-container').classList.remove('container-out');

        document.querySelector('#mymodal-back').classList.add('bg-in');
        document.querySelector('#mymodal-back .mymodal-container').classList.add('container-in');

        this.isModalOn = true;
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

        accept.className = "btn btn-primary mymodal-button modal-accept";
        cancel.className = "btn btn-primary mymodal-button modal-cancel";

        accept.textContent = "Aceptar";
        cancel.textContent = "Cancelar";

        accept.onclick = acceptFunction;
        cancel.onclick = this.Cancel;

        footer.appendChild(accept);

        if (showCancelButton) {
            footer.appendChild(cancel);
        }

        header.appendChild(headerTitle);

        container.appendChild(header);
        container.appendChild(body);
        container.appendChild(footer);

        back.appendChild(container);

        document.querySelector('body').appendChild(back);
    },
    RenderButtons: function (acceptFunction, showCancelButton) {
        let footer = document.querySelector('.mymodal-footer');
        let accept = document.createElement('button');
        let cancel = document.createElement('button');

        footer.appendChild(accept);

        if (showCancelButton) {
            footer.appendChild(cancel);
        }

        accept.className = "btn btn-primary mymodal-button modal-accept";
        cancel.className = "btn btn-primary mymodal-button modal-cancel";

        accept.textContent = "Aceptar";
        cancel.textContent = "Cancelar";

        accept.onclick = acceptFunction;
        cancel.onclick = this.Cancel;
    },
    Cancel: function () {
        Modal.Close()
    },
    Close: function () {
        let bodyChild = document.querySelector('#mymodal-back .mymodal-body').firstChild;

        let parent = this.NodeParent;

        parent.appendChild(bodyChild);
        parent = null;

        document.querySelector('#mymodal-back').classList.remove('bg-in');
        document.querySelector('#mymodal-back .mymodal-container').classList.remove('container-in');

        document.querySelector('#mymodal-back').classList.add('bg-out');
        document.querySelector('#mymodal-back .mymodal-container').classList.add('container-out');

        let footer = document.querySelector('#mymodal-back .mymodal-footer');

        while (footer.firstChild) {
            footer.removeChild(footer.firstChild);
        }

        this.isModalOn = false;
    }
}