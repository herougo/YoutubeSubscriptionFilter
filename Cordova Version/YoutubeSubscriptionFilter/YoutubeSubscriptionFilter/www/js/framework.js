"use strict";

/* KNOWN ISSUES
Youtube Api call does not order by published date 
(ie YoutubeApi.getVideos('RoosterTeeth', ["h1xHP-NpJkY"], null, function(yo) { console.log(yo); });)
*/

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
    Main.path.css('height', Framework.original_window_height).css('width', Framework.original_window_width);
};

$(document).ready(function () {
    Framework.onReady();
});


var YoutubeApi = {};

YoutubeApi.key = 'AIzaSyCgPP1AJYXPnd37DvDmGVLwqbJDesABROc';


// return object with keys:
// - uploadKey
// - results (new videos ordered with newest first)
/* Example Output
[{
    title: "Pan movie review"
    description: "Peter Pan gets the "Fant4stic" treatment...Jeremy murders...er....reviews "Pan". See more videos by Jeremy here: http://www.youtube.com/user/JeremyJahns Follow Jeremy on Twitter: https://twitter.com/JeremyJahns Friend Jeremy on Facebook: http://www.facebook.com/RealJeremyJahns Subscribe to Jeremy's blog at www.JeremyJahns.com"
    videoId: "35wyIKt_6gc"
    thumbnails: {
        default: {
            height: 90
            url: "https://i.ytimg.com/vi/35wyIKt_6gc/default.jpg"
            width: 120
       }, high: {
            height: 360
            url: "https://i.ytimg.com/vi/35wyIKt_6gc/hqdefault.jpg"
            width: 480
        }, maxres: {
            height: 720
            url: "https://i.ytimg.com/vi/35wyIKt_6gc/maxresdefault.jpg"
            width: 1280
        }, medium: {
            height: 180
            url: "https://i.ytimg.com/vi/35wyIKt_6gc/mqdefault.jpg"
            width: 320
        }, standard: {
            height: 480
            url: "https://i.ytimg.com/vi/35wyIKt_6gc/sddefault.jpg"
            width: 640
        }
    }
}]
Example Call: 
YoutubeApi.getVideos('JeremyJahns', ["35wyIKt_6gc"], null, function(yo) { console.log(yo); });
*/

YoutubeApi.getVideos = function (user, stop_ids, uploadKey, onComplete) {
    //Get Videos
    function getVids(pid, pageToken) {
        var params = {
            part: 'snippet',
            maxResults: max_results,
            playlistId: pid,
            order: 'date',
            key: YoutubeApi.key
        };
        if (pageToken) { params.pageToken = pageToken; }

        $.get(
            "https://www.googleapis.com/youtube/v3/playlistItems", params,
            function (data) {
                iterator_len = Math.min(max_results, data.items.length);
                for (i = 0; i < iterator_len; i++) {
                    if (stop_ids.indexOf(data.items[i].snippet.resourceId.videoId) !== -1) {
                        done = true;
                        break;
                    }
                    output.results.push({
                        title: data.items[i].snippet.title,
                        description: data.items[i].snippet.description,
                        videoId: data.items[i].snippet.resourceId.videoId,
                        thumbnails: jQuery.extend({}, data.items[i].snippet.thumbnails)
                    });
                }

                if (done || !data.nextPageToken) {
                    onComplete && onComplete(output);
                } else {
                    getVids(pid, data.nextPageToken)
                }
            }
        ).fail(onComplete);
    }    

    var output = {},
        max_results = 20,
        done = false,
        i, iterator_len;
    output.results = [];

    // Get Uploads Playlist
    if (uploadKey) {
        output.uploadKey = uploadKey;
        getVids(uploadKey);
    } else {
        $.get(
           "https://www.googleapis.com/youtube/v3/channels", {
               part: 'contentDetails',
               forUsername: user,
               key: YoutubeApi.key
           }, function (data) {
               if (data.items.length !== 1) {
                   console.log("Caution: Incorrect number of upload keys for " + user + ": " + data.items.length);
                   onComplete && onComplete();
               } else {
                   $.each(data.items, function (i, item) {
                       output.uploadKey = item.contentDetails.relatedPlaylists.uploads;
                       getVids(output.uploadKey);
                   });
               }
           }).fail(onComplete);
    }
};

Framework.testYoutubeApi = function (user) {
    

};

/*
    //Get Videos
    function getVids(pid) {
        $.get(
            "https://www.googleapis.com/youtube/v3/playlistItems", {
                part: 'snippet',
                maxResults: 20,
                playlistId: pid,
                key: 'AIzaSyCgPP1AJYXPnd37DvDmGVLwqbJDesABROc'
            },
            function (data) {
                var results;
                console.log(data);
                $('#results').empty();
                $.each(data.items, function (i, item) {
                    results = '<li>' + item.snippet.title + '</li>';
                    $('#results').append(results);
                });
            }
        );
    }

    // Get Uploads Playlist
    $.get(
       "https://www.googleapis.com/youtube/v3/channels", {
           part: 'contentDetails',
           forUsername: user,
           key: 'AIzaSyCgPP1AJYXPnd37DvDmGVLwqbJDesABROc'
       },
       function (data) {
           console.log(data);
           $.each(data.items, function (i, item) {
               var pid = item.contentDetails.relatedPlaylists.uploads;
               getVids(pid);
           });
       }
    );
*/