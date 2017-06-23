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
            var a = chords[i].getElementsByTagName("a")[0];

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
}

