// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    var PlaceHolderElement = $('#PlaceHolderHere');
    var url = '';
    $('button[data-toggle="ajax-modal-add"]').click(function (event) {
        url = $(this).data('url-add');
        $.get(url).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find('.modal').modal('show');
        })
    })

    $('button[data-toggle="ajax-modal-edit"]').click(function (event) {
        url = $(this).data('url-edit');
        var decodedUrl = decodeURIComponent(url);
        $.get(decodedUrl).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find('.modal').modal('show');
        })
    })
    
    PlaceHolderElement.on('click', '[data-save="modal"]', function (event) {
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var sendData = form.serialize();
        $.post(actionUrl, sendData).done(function (data) {
            PlaceHolderElement.find('.modal').modal('hide');
        });
    })

    PlaceHolderElement.on('click', '[data-delete="modal"]', function (event) {
        var form = $(this).parents('.modal').find('form');
        var actionUrl = $(this).data('url-delete');
        var decodedUrl = decodeURIComponent(actionUrl);
        var sendData = form.serialize();
        $.post(decodedUrl, sendData).done(function (data) {
            PlaceHolderElement.find('.modal').modal('hide');
        });
    })
})