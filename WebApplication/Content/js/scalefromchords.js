

function filterChords() {
    var filterText = document.getElementById("filter-chords").value;
    if (filterText) {
        filterText = filterText.toLowerCase();
        var ul = document.getElementById("chords-list");
        var chords = ul.getElementsByTagName("li");

        for (var i = 0; i < chords.length; i++) {
            var a = chords[i].getElementsByTagName("button")[0];

            if (a.innerHTML.toLowerCase().indexOf(filterText) > -1) {
                chords[i].style.display = "";
            }
            else {
                chords[i].style.display = "none";
            }
        }
    }
    else {
        var chords = document.getElementById("chords-list").getElementsByTagName("li");
        for (var i = 0; i < chords.length; i++) {
            chords[i].style.display = "";
        }
    }
};

function getMatchingScales() {
    var chordsHtml = document.getElementsByClassName('selected-chords')[0].childNodes;

    var chords = [chordsHtml.length - 1];
    var rowIterator = 0;
    for (var i = 1; i < chordsHtml.length; i++)
    {
        if (chordsHtml[i].innerHTML != null) {
            chords[rowIterator] = chordsHtml[i].innerHTML;
            rowIterator++;
        }
    }

    var postdata = { chords: chords };

        $.ajax({
            url: '/scalefromchords/getmatchingscales',
            data: postdata,
            method: 'POST',
            datatype: 'json',
            success: function(response, status) {
                console.log(response);
                var scales = response;

                var elementList = document.getElementsByClassName('matching-scales');
                if (elementList == null)
                    return;

                var matchingScalesElement = elementList[0];
                while (matchingScalesElement.firstChild) {
                    matchingScalesElement.removeChild(matchingScalesElement.firstChild);
                }

                for (i = 0; i < scales.length; i++) {
                    addScaleButton(scales[i], matchingScalesElement);
                }
            },
            error: function (response, status, error) {
                alert('An error has occured');
            }
        });
}

function addScaleButton(scaleName, matchingScalesElement) {
    var htmlToInject = "<button class=\"scales\">" + scaleName + "</button>";

    var div = document.createElement('button');
    div.innerHTML = htmlToInject;

    matchingScalesElement.appendChild(div.firstChild);
}


$(function () {
    // Using on because button was added dynamically, source: https://stackoverflow.com/questions/24099940/click-event-is-not-working-for-dynamically-added-button
    $(document).on('click', '.scales', function (e) {
        $.get('/scalefromchords/onscaleselected?scalename=' + e.target.innerHTML);
    });

    // ON CHORDS BUTTON CLICKED BEHAVIOR
    $('.chords').click(function (e) {
        var button = e.target;
        var newContainer = null;

        if (button.parentNode.className.indexOf('available-chords') !== -1) {
            newContainer = document.getElementsByClassName('selected-chords');
        }
        else if (button.parentNode.className.indexOf('selected-chords') !== -1) {
            newContainer = document.getElementsByClassName('available-chords');
        }
        if (newContainer != null) {
            button.parentNode.removeChild(button);
            newContainer[0].appendChild(button);
            getMatchingScales();
        }
    });
});