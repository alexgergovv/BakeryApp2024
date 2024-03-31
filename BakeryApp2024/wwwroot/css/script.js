javascript
function initMap() {
    var mapOptions = {
        center: { lat: 40.7128, lng: -74.0060 }, // Specific latitude and longitude coordinates
        zoom: 12
    };

    var map = new google.maps.Map(document.getElementById('map'), mapOptions);
}