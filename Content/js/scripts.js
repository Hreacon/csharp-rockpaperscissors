$(document).ready(function() {
  var player1keys = "qwe";
  var player2keys = "poi";
  var player1 = '';
  var player2 = '';
  var gameStarted = false;

  $("#input").focusout(function() {
    console.log("Focus!");
    $("#input").focus();
  });

  $("#input").keypress(function(event) {

    if( event.which == 13){ // if enter button is pressed
      event.preventDefault();//, prevent form submit
    } else if(event.which == 32) {
      // start the countdown
      gameStarted = true;
      $(".countdown").text("3");
      var TimeoutID = window.setTimeout(function(){$(".countdown").text("2");},1500);
      var TimeoutID = window.setTimeout(function(){$(".countdown").text("1");},3000);
      var TimeoutID = window.setTimeout(function(){$(".countdown").text("0");},4500);
      var TimeoutID = window.setTimeout(function(){window.location.href="/";},6000);
      // $(".countdown").text("2").delay(10000);
    }

    if(gameStarted) {
      // console.log(String.fromCharCode(event.which));
      var input = String.fromCharCode(event.which); // take character code and turn it into the character pressed
      if( player1keys.indexOf(input) > -1 ) // player 1 input
      {
        player1 = input;
      } else if( player2keys.indexOf(input) > -1 ) // player 2 input
      {
        player2 = input;
      }
      if(player1.length > 0 && player2.length > 0)
      {
        // both players have input, forward to game
        window.location.href="/play/"+player1+"/"+player2;
      }
    }
    $("#input").val("");
  });
});
