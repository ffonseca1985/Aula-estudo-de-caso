
(function () {

    getCurrentToken();

    function getCurrentToken(){

        $.get('/Token/Get', function (token) {
            $("#token").text(token.Id);
            $("#tokenExpire").text(token.TimeExpire + " Minutos");
        });
    }

	$("#btnToken").on("click", function () {
		var jqxhr = $.post('/Token', function (token) {
			alert("token gerado com sucesso!");
			$("#token").text(token.Id);
			$("#tokenExpire").text(token.TimeExpire + " Minutos");
		});

		jqxhr.fail(function () {
			alert("Erro ao gerar o token, por favor tente mais tarde!");
		});
	});
})();