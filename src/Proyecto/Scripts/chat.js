function Click(idSala, usuario) {

    var men = document.querySelector('#mensaje').value
    var dat = new Date();
    console.log(men);
    console.log("fecha" + dat);
    fetch('/api/Mensaje/GuardarMensaje/', {
        method: 'post',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ Texto: men, Fecha: dat, IdSala:idSala, Usuario:usuario })
    })
        .then(function (response) {
            if (response.status !== 200) {
                console.log('fetch returned not ok' + response.status);
            }
            else
            {                
                console.log('fetch returned ok');             
            }
        })
        .catch(function (err) {
            console.log(`error: ${err}`);
        });
}