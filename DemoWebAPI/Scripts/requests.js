﻿
//Simple jQuery methods which issue an AJAX
//request to our Web API controllers, when the get request hits
//the code in our controller is executed

//This document.ready is a jQuery method used to ensure scripts are not
//executed until the document object model (the web page) is fully rendered
$(document).ready(function () {

    var values = [];

    //Another jQuery method, which creates an event handler for us
    //when the element with the CSS ID of Sum (we know its ID and not class because of #)
    // SEE CSS SELECTORS it will execute the enclosed anonymous function
    //this is called an anonymous function because we do not name it.
    //$('#sum').click(function () {

    //    //Simple jQuery AJAX call method
    //    $.ajax({
    //        url: '/api/sum',
    //        cache: false,
    //        //upon successfull request (not 300/400 response)
    //        //it will execute this method
    //        success: function (response) {
    //            //jQuery method which replaces an element's text with
    //            //the response data passed from the AJAX success callback
    //            //method
    //            $('#response').text(response);
    //        }
    //    });
    //});

    $('#sum').click(function () {
        
        $.ajax({
            type: "GET",
            url: '/api/sum',
            data: { list: values},
            cache: false,
            success: function (response) {
                $('#response').text(response);
            }
        });
    });

    //another example, except this calls our largest controller
    $('#largestNum').click(function () {
        $.ajax({
            type: "GET",
            url: '/api/largest',
            data: {list:values},
            cache: false,
            success: function (response) {
                $('#response').text(response);
            }
        });
    });

    $('#smallestNum').click(function () {
        $.ajax({
            type: "GET",
            url: '/api/smallest',
            data: {list:values},
            cache: false,
            success: function (response) {
                $('#response').text(response);
            }
        });
    })

    $('#populaterandoms').click(function () {
        senddata = { total: prompt("Enter number of random values:") }

        $.ajax({
            type: "GET",
            url: '/api/randoms',
            data: senddata,
            cache:false,
            success: function (response){
                values = response;
                $('#values').text(values);
            }
        })

    })

    $('#inputVal').click(function () {
        values.push($('#val').val());

        $('#values').text(values);
        $('#val').val('');
    });
});