// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function CallTransient() {
    debugger;

    var origin = window.location.origin;

    $("#AlertResponseTransient").empty();

    var jqxhr = $.get(origin + "/api/Transient/CallMe", function (data) {
        $("#AlertResponseTransient").append(data);
    })
        .fail(function () {
            alert("error");
        });

    jqxhr = $.get(origin + "/api/Transient/CallMeAgain", function (data) {
        $("#AlertResponseTransient").append(data);
    })
        .fail(function () {
            alert("error");
        });
}

function CallScoped() {
    var origin = window.location.origin;

    $("#AlertResponseScoped").empty();

    var jqxhr = $.get(origin + "/api/Scoped/CallMe", function (data) {
        $("#AlertResponseScoped").append(data);
    })
        .fail(function () {
            alert("error");
        });

    jqxhr = $.get(origin + "/api/Scoped/CallMeAgain", function (data) {
        $("#AlertResponseScoped").append(data);
    })
        .fail(function () {
            alert("error");
        });
}

function CallSingelton() {
    var origin = window.location.origin;

    $("#AlertResponseSingelton").empty();

    var jqxhr = $.get(origin + "/api/Singleton/CallMe", function (data) {
        $("#AlertResponseSingelton").append(data);
    })
        .fail(function () {
            alert("error");
        });

    jqxhr = $.get(origin + "/api/Singleton/CallMeAgain", function (data) {
        $("#AlertResponseSingelton").append(data);
    })
        .fail(function () {
            alert("error");
        });
}

