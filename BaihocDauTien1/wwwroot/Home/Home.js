document.addEventListener("DOMContentLoaded", function () {
    console.log("Trang đã tải xong!");
    alert("Chào mừng đến với web bán acc!");
    const images = document.querySelectorAll('.acc-img');
    const popup = document.getElementById('img-popup');
    const popupImg = document.getElementById('popup-img');
    const closeBtn = document.querySelector('.close-btn');

    images.forEach(img => {
        img.addEventListener('click', function () {
            popup.style.display = 'flex';
            popupImg.src = this.src;
        });
    });

    closeBtn.addEventListener('click', function () {
        popup.style.display = 'none';
    });

    popup.addEventListener('click', function (e) {
        if (e.target === popup) {
            popup.style.display = 'none';
        }
    });
    document.querySelectorAll(".mua-btn").forEach(button => {
        button.addEventListener("click", function () {
            const result = confirm("Ban co chac muon mua con acc nay ko");
            if (result) {
                alter("Da them vao gio hang thanh cong");
            }
        });
    });
});