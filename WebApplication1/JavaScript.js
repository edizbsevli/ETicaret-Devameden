var cart = [];

function addToCart(productId, productName, price) {
    cart.push({
        id: productId,
        name: productName,
        price: price
    });

    updateCart();
}

function updateCart() {
    var cartItems = document.getElementById('cartItems');
    var totalPrice = document.getElementById('totalPrice');
    var total = 0;

    cartItems.innerHTML = '';

    cart.forEach(function (item) {
        var li = document.createElement('li');
        li.textContent = item.name + ' - $' + item.price;
        cartItems.appendChild(li);

        total += item.price;
    });

    totalPrice.textContent = total;
}

function checkout() {
    alert('Ödeme işlemi başarıyla tamamlandı!');
    cart = [];
    updateCart();
}

function clearCart() {
    cart = [];
    updateCart();
}