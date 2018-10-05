$('.removertr').click(function () {
    var linha = $(this).closest('tr');
    var idDoProduto = $(this).parent().parent().find(".idItem").text();
    var tipoDoProduto = $(this).parent().parent().find(".tipoItem").text();
    var parametros = { id: idDoProduto, tipo: tipoDoProduto };
    $.ajax({ url: "/Carrinho/Exclui", data: parametros, method: "POST" }).done(function () {
        alert("item excluido");
    })
    linha.remove();
});