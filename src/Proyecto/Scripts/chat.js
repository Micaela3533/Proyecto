
setInterval(function hola() {
    fetch('/api/Mensaje/GetMensajexSalas/135')
        .then(res => res.json())

        .then(json_extraido => {

           // console.log("json.search", json_extraido);
            var div = document.getElementById("chat_s");
            div.innerHTML = "";
            for (var i = 0; i < json_extraido.length; i++) {
                var entry = json_extraido[i];
                var a, b;
                a = entry.Usuario;
                b = "";
                
                div.innerHTML +=
                    '<div class="chat' +
                    b +
                    '"><div class="chat_name">' +
                    a +
                    '</div><div class="chat_message">' +
                    entry.Texto +
                    "</div></div>";
            }
        })
        .catch(error => console.log("Fallo:" + error));


}, 1000);

    //código a ejecutar cuando el DOM está listo para recibir acciones
    /*
    fetch('/api/Mensaje/GetMensajexSalas/135', {
        
        //body: JSON.stringify({ idSala: 5 })
    })

        .then(function (response) {
            console.log("hola");
            if (response.status !== 200) {
                console.log('fetch returned not ok' + response.status);
            }
            console.log(response.text());
            
        })
        response.json().then(function (data) {
        console.log('fetch returned ok');
        console.log(data);
    });
        .catch(function (err) {
            console.log(`error: ${err}`);
        });
});
function Click() {

    var men = document.querySelector('#mensaje').value
    console.log(men)
    fetch('/Home/SalaCreada', {
        method: 'post',
        body: JSON.stringify({ mensaje: men})
    })
        .then(function (response) {
            if (response.status !== 200) {
                console.log('fetch returned not ok' + response.status);
            }

            response.json().then(function (data) {
                console.log('fetch returned ok');
                console.log(data);
            });
        })
        .catch(function (err) {
            console.log(`error: ${err}`);
        });
}*/


