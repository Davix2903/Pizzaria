$('.removertr').click(function () {
    var linha = $(this).closest('tr');
    var idDoProduto = $(this).parent().parent().find(".idItem").text();
    var tipoDoProduto = $(this).parent().parent().find(".tipoItem").text();
    var parametros = { id: idDoProduto, tipo: tipoDoProduto };
    $.ajax({ url: "/Carrinho/Exclui", data: parametros, method: "POST" }).done(function () {
        alert("item excluido");
    });
    linha.remove();
});



$('.adicionarqtd').on('click', function () {
    var $linha = $($(this).parent().parent().parent().parent().parent());

    var qtd = $(this).parent().parent().parent().find('.quantidade');

    var quantidade = qtd.val();

    qtd.val((Number.parseInt(quantidade)) + 1);

    var precoProduto = $linha.find('.precoProduto').text().split(" ")[1];

    var tdSubtotal = $linha.find('.subtotalProduto');

    tdSubtotal.text("R$ " + (quantidade * precoProduto).toFixed(2).replace('.', ','));

    var IdProduto = $linha.find('.IdProduto').text();

    var tipoDoProduto = $(this).parent().parent().parent().parent().find(".tipoDoProduto").text();
    console.log(tipoDoProduto);

    var url = '/Carrinho/AumentaQtd';
    var parametros = { Id: IdProduto, tipo: tipoDoProduto };
    $.ajax(url, { data: parametros, method: "POST" }).done(function () {

    })

    atualizaTotal();

});


$('.removerqtd').on('click', function () {
    var $linha = $($(this).parent().parent().parent().parent().parent());

    var qtd = $(this).parent().parent().parent().find('.quantidade');

    var quantidade = qtd.val();

    qtd.val((Number.parseInt(quantidade)) - 1);

    var precoProduto = $linha.find('.precoProduto').text().split(" ")[1];

    var tdSubtotal = $linha.find('.subtotalProduto');

    tdSubtotal.text("R$ " + (quantidade * precoProduto).toFixed(2).replace('.', ','));

    var IdProduto = $linha.find('.IdProduto').text();

    var tipoDoProduto = $(this).parent().parent().parent().parent().find(".tipoDoProduto").text();
    console.log(tipoDoProduto);

    var url = '/Carrinho/DiminuiQtd';
    var parametros = { Id: IdProduto, tipo: tipoDoProduto };
    $.ajax(url, { data: parametros, method: "POST" }).done(function () {

    })

    atualizaTotal();

});


//$('.diminuirqtd').click(function () {
//    var linha = $(this).remove('tr');
//    var idDoProduto = $(this).parent().parent().find(".idItem").text();
//    var tipoDoProduto = $(this).parent().parent().find(".tipoItem").text();
//    var parametros = { id: idDoProduto, tipo: tipoDoProduto };
//    $.ajax({ url: "/Carrinho/DiminuiQdt", data: parametros, method: "POST" }).done(function () {
//        alert("item excluido");
//    })
//    linha.remove();
//});

//$('.aumentarqtd').click(function () {
//    var linha = $(this).add('tr');
//    var idDoProduto = $(this).parent().parent().find(".idItem").text();
//    var tipoDoProduto = $(this).parent().parent().find(".tipoItem").text();
//    var parametros = { id: idDoProduto, tipo: tipoDoProduto };
//    $.ajax({ url: "/Carrinho/AumentaQtd", data: parametros, method: "POST" }).done(function () {
//        alert("item excluido");
//    })
//    linha.remove();
//});