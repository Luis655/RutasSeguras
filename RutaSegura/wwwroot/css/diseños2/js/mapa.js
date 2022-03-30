

var map = L.map('map').setView([20.971016082617087, -89.62735414449673], 13);

L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
}).addTo(map);










var popup = L.popup();

function onMapClick(e) {
    popup
        .setLatLng(e.latlng)
        .setContent("You clicked the map at " + e.latlng.toString())
        .openOn(map);
}

map.on('click', onMapClick);


//const url = 'http://localhost:5264/Lugares/GetAll2'
//const HTMLResponse = document.querySelector("map")



fetch('http://localhost:5264/Lugares/GetAll2')
    .then(response => response.json())
    .then(data =>{
            data.forEach(element => {
                
                var Latitud = parseFloat(element.latitud);
                var Longitud = parseFloat(element.longitud);

                console.log(data)
                var mensaje2;
                    if (element.verificacion) {
                        mensaje2 ="verificado"
                    } else {
                        mensaje2 ="no verificada"
                    }
              
               
                if (element.tipopeligro == "REGULAR") {

                    
                   
                    var circle = L.circle([Latitud, Longitud], {
                        color: 'orange',
                        fillColor: 'orange',
                        fillOpacity: 0.5,
                        radius: 300
                    }).addTo(map)
                    .bindPopup(mensaje2)
                    .openPopup();
                    L.marker([Latitud, Longitud],{
                        circle
                    }).addTo(map)
                      .bindPopup(element.descripcion)
                      .openPopup()
                }

                if (element.tipopeligro == "ALTO") {

                    
                    
                    var circle = L.circle([Latitud, Longitud], {
                        color: 'red',
                        fillColor: 'red',
                        fillOpacity: 0.5,
                        radius: 300
                    }).addTo(map)
                    .bindPopup(mensaje2)
                    .openPopup();
                    L.marker([Latitud, Longitud],{
                        circle
                    }).addTo(map)
                      .bindPopup(element.descripcion)
                      .openPopup()
                }

                if (element.tipopeligro == "BAJO") {
                    
                    var circle = L.circle([Latitud, Longitud], {
                        color: 'blue',
                        fillColor: 'blue',
                        fillOpacity: 0.5,
                        radius: 300
                    }).addTo(map)
                    .bindPopup(element.descripcion)
                    .openPopup();
                    L.marker([Latitud, Longitud],{
                        circle
                    }).addTo(map)
                      .bindPopup(mensaje2)
                      .openPopup()
                }
               
                
              })})
                //console.log(element.latitud, element.longitud)
                
    




