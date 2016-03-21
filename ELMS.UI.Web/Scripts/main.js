var newLat;
var newLong;
var newFormattedAddress;

function select2WidthHelper(select2Element) {
    select2Element.next().css("maxWidth", "280px").css("width","100%");
}

function updateFormValidation(form) {
    $('#' + form + 'FormId input,select').keyup(function () {
        updateUI(form);
    });
    $('#' + form + 'FormId select').change(function () {
        updateUI(form);
    });
}

function updateUI(form) {
    if (!$('#' + form + 'FormId').valid()) {
        $('#' + form + 'FormId input[type="submit"]')
            .removeClass("btn-default")
            .removeClass("btn-success")
            .addClass("btn-danger").prop('disabled', true);
    }
    else {
        $('#' + form + 'FormId input[type="submit"]')
            .removeClass("btn-default")
            .removeClass("btn-danger")
            .addClass("btn-success").prop('disabled', false);
    }
}

function initMap(id) {
    var map = new google.maps.Map(document.getElementById('map'));
    var geocoder = new google.maps.Geocoder();
    geocodeAddress(geocoder, map, id);
}

function geocodeAddress(geocoder, resultsMap, id) {
    document.getElementById(id).parentElement.style.display = 'block';
    var address = document.getElementById('Street').value + ' ' +
        document.getElementById('AptSuiteOther').value + ' ' +
        document.getElementById('City').value + ' ' +
        document.getElementById('Zip').value;
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status === google.maps.GeocoderStatus.OK) {
            newLat = results[0].geometry.location.lat();
            newLong = results[0].geometry.location.lng();
            newFormattedAddress = results[0].formatted_address;
            var latlng = new google.maps.LatLng(newLat, newLong);
            var mapOptions = {
                zoom: 8,
                center: latlng, 
                scrollwheel: false,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            }
            map = new google.maps.Map(document.getElementById('map'), mapOptions);
            map.setCenter(latlng)

            //resultsMap.setCenter(results[0].geometry.location);
            var marker = new google.maps.Marker({
                map: map,
                position: results[0].geometry.location
            });
            google.maps.event.trigger(map, "resize");
        } else {
            document.getElementById(id).parentElement.style.display = 'none';
            //alert('Geocode was not successful for the following reason: ' + status);
        }
    });
}