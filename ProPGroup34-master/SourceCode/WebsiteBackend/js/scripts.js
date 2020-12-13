$(document).ready(function(){

    // ---------------- AJAX LOGIN ------------------//
    $("#loginForm").submit(function(event){
			event.preventDefault();

			var posting = $.post("login_action.php", {username: $("#username").val(), password: $("#password").val()});
			posting.done(function(data){
				if (data == "success") {
					window.location.href = "participant.php";
				}
				else {
					alert('Login unsuccessful');
				}
			});
		});
		
	$('#activateCampForm').submit(function(event) {
		event.preventDefault();

			var posting = $.post("activate_camp.php", {activationcode: $("#activationcode").val()});
			posting.done(function(data){
				if (data == "success") {
					window.location.href = "participant.php";
				}
				else {
					alert('Camp registered unsuccessful');
				}
			});
		});
});