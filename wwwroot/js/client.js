$(function(){
    //alert("Hello World");
    $(function(){
      // preload audio
      var toast = new Audio('media/toast.wav');
  
  $('.code').on('click', function(e) {
      e.preventDefault();
  
      
      //alert($(this).data("code"));
      //$('product').((this).data('name'));
      //$(this).data('code');
      
      
      // first pause the audio (in case it is still playing)
      toast.pause();
      // reset the audio
      toast.currentTime = 0;
      // play audio
      toast.play();
      console.log("Playing toast.");
      $("#product").html($(this).data("product"));
      $("#code").html($(this).data("code"));
      $('#toast').toast({ autohide: false }).toast('show');        
  });

  $('.customerSubmit').on('click', function(e) {
    e.preventDefault();

    console.log("Customer is submitting");
  });
  
  $(document).on('keyup', function(e) {
      if(e.which == 27) {
        $("#toast").toast("hide");
      }
  });
  });
  });