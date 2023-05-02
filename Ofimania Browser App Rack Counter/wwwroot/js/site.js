function errorBarCode()
{
    alert('¡Código de Barra Erróneo!');
}

function errorNoProduct()
{
	alert('¡No existe dicho Producto!');
}

function errorInvalidInput() {
    alert('¡Entrada Invalida!');
}

window.onFocus = (id) => {
    var currInput = document.activeElement;
    if (currInput.tagName.toLowerCase() == "input") {
        var inputs = document.getElementsByTagName("input");
        var currInput = document.activeElement;
        for (var i = 0; i < inputs.length; i++) {
            if (inputs[i] == currInput) {
                var next = inputs[i + 1];
                if (next && next.focus) {
                    next.focus();
                }
                break;
            }
        }
    }
} 