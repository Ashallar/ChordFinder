//$(function () {

//    $('filter-chords').bind('input', function () {
//        alert("filter");
//        var filterText = $(this).val();

//        var chords = documents.getElementsByClassName("chords-list").children;

//        for (var i = 0; i < chords.length; i++) {
//            if (chords[i].innerHTML.search(filterText) == -1) {
//                chords[i].style.visibility = "hidden";
//            }
//        }
//    });


//});


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
            method: 'POST'
        });
}

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
