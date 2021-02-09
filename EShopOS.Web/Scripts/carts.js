/*
    Add to cart fly effect with jQuery. - May 05, 2013
    (c) 2013 @ElmahdiMahmoud - fikra-masri.by
    license: https://www.opensource.org/licenses/mit-license.php
*/

$('.add-to-cart').on('click', function () {
    var productId = $(this).data("id");
    $.ajax({
        type: "POST",
        url: "Shop/AddCartItem",
        data: { productId: productId },
        success: function (data) {
            effect(productId);
            setTimeout(function () {
                $(".cartItems").text(data);
            }, 1500);
        }
    });
});


