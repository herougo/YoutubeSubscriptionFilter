"use strict"

var Main = {};
Main.path;

/* the javascript is a in progress until I can figure out including jquery */

var Framework = {};
Framework.original_window_height;
Framework.original_window_width;

Framework.onReady = function() {
    Framework.original_window_height = $(window).height();
    Framework.original_window_width = $(window).width();

    Main.path = $('#main');
    Main.path.css('height', Framework.original_window_height).css('width', Framework.original_window_height);
};

$(document).ready(function () {
    Framework.onReady();
});