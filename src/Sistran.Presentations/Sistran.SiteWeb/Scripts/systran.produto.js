
(function () {

    var Produto = function (id, nome, descricao, preco) {

        this.Id = id;
        this.Nome = nome;
        this.Descricao = descricao;
        this.Preco = preco
    }

    $("#btnProduto").on("click", function () {

        var idToken = $.cookie("idToken")

        if (idToken == null || idToken == undefined) {
            alert("Favor gerar um token!");
            return;
        }

        var urlprodutoApi = "http://localhost:63515/api/produto/token/" + idToken;

        $.get(urlprodutoApi, function (produtos) {
            
            if (produtos.length > 0) {

                var produtosArray = [];

                for (var i = 0; i < produtos.length; i++) {
                    produtosArray.push(new Produto(produtos[i].id, produtos[i].nome, produtos[i].descricao, produtos[i].preco));
                }

                $.ajax({
                    type: "GET",
                    url: '/Produto/Table',
                    data: { "produtos": JSON.stringify(produtosArray) },
                    dataType: "html",
                    success: function (htmlTable) {
                        alert('Talvez vc não perceba, mas está preechendo via Ajax!!');
                        $("#tableProdutos").html(htmlTable);
                    },
                    error: function (err) {
                        alert("Erro ao prencher via ajax, reinicie o projeto!!");
                    }
                });
            } else {
                $("#tableProdutos").html("<div class='alert alert-info'>Token expirado, favor gerar outro novamente!</div>");
            }

        });
    });

})();