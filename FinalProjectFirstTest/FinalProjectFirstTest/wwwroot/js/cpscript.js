$("#switch").on('click', function () {
		if ($("body").hasClass("fire-off")) {
			$("body").removeClass("fire-off");
			$("#switch").removeClass("switched");
		}
		else {
			$("body").addClass("fire-off");
			$("#switch").addClass("switched");
			window.setTimeout(( () => window.location.href="./sss.html" ), 2000);
			
		}
	});